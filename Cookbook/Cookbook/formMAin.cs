using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Cookbook
{
    public partial class formMAin : Form
    {
        string connectionString;
        SqlConnection connection;

        public formMAin()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.cookbookConnectionString"].ConnectionString;
        }

        private void formMAin_Load(object sender, EventArgs e)
        {
            populateRecipeList();
            populateList("SELECT * FROM Ingredient", "Name", listAllIngredients);
            
            populateShopList();
        }

        private void populateRecipeList()
        {
            int index = listRecipe.SelectedIndex;
            populateList("SELECT * FROM Recipe", "Name", listRecipe);
            populateList("SELECT (CAST(CAST(PrepTime AS int) AS varchar)+ ' + '+Instructions) as PrepTimeIns FROM Recipe", "PrepTimeIns", listPrepTimeIns);
            if(index != -1)
                listRecipe.SetSelected(index, true);
        }

        private void populateShopList()
        {
            populateList("SELECT * FROM ShoppingList", "Name", shopList1);
            populateList("SELECT * FROM ShoppingList", "Weight", shopList2);
            populateList("SELECT * FROM ShoppingList", "Price", shopList3);
            populateList("SELECT * FROM ShoppingList", "ExpirationDate", shopList4);
        }

        private void populateList(string query, string displayMember, ListBox listbox)
        {
            // adapter open, using close connection
            int index = listbox.SelectedIndex;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable Table = new DataTable();
                adapter.Fill(Table);

                listbox.DisplayMember = displayMember;
                listbox.ValueMember = "Id";
                listbox.DataSource = Table;
            }
            try
            {
                listbox.SetSelected(index, true);
            }
            catch(System.ArgumentOutOfRangeException)
            { }            
        }

        private void populateIngredientsList(string displayMember)
        {
            string query = "SELECT a." + displayMember + " FROM Ingredient a " +
                " inner join RecipeIngredient b on a.Id = b.IngredientId " +
                "where b.RecipeId = @RecipeId";

            // adapter opens, using close connection
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", listRecipe.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);
            
                listIngredients.DisplayMember = displayMember;
                listIngredients.ValueMember = "Id";
                listIngredients.DataSource = ingredientTable;
            }
        }

        private void listRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT (CAST(CAST(PrepTime AS int) AS varchar)+ ' + '+Instructions) as PrepTimeIns FROM Recipe WHERE Id = @Id";
            string result;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", listRecipe.SelectedValue);
                DataTable table = new DataTable();
                adapter.Fill(table);
                result = table.Rows[0][0].ToString();
            }
            int index = listPrepTimeIns.FindString(result);
            if (index != -1)
            listPrepTimeIns.SetSelected(index, true);
            populateIngredientsList("Name");
        }

        private void ButtonAddRecipe_Click(object sender, EventArgs e)
        {   
            try
            {
                string query;
                string[] stringArray = textBox.Text.Split(new[] { ',', ';', ' ' });
                query = "INSERT INTO Recipe(Name) VALUES (@Name)";
                if (stringArray.Length > 1)
                    query = "INSERT INTO Recipe(Name, PrepTime) VALUES (@Name, @Weight)";
                if (stringArray.Length > 2)
                    query = "INSERT INTO Recipe(Name, PrepTime, Instructions) VALUES (@Name, @Weight, @Price)";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", stringArray[0]);
                    if (stringArray.Length > 1)
                        command.Parameters.AddWithValue("@Weight", stringArray[1]);
                    if (stringArray.Length > 2)
                        command.Parameters.AddWithValue("@Price", stringArray[2]);
                    command.ExecuteScalar();
                }
                populateRecipeList();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Wrong inserted data", "Update",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void ButtonUpdateRecipe_Click(object sender, EventArgs e)
        {
            string query = "Update Recipe Set Name = @RecipeName where Id = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", textBox.Text);
                command.Parameters.AddWithValue("@RecipeId", listRecipe.SelectedValue);

                command.ExecuteScalar();
            }
            populateList("SELECT * FROM Recipe", "Name", listRecipe);
        }

        private void buttonAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient VALUES (@RecipeId, @IngredientId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeId", listRecipe.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            populateIngredientsList("Name");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddShopList_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                string[] stringArray = textShopList.Text.Split(new[] { ',', ';', ' ' });
                query = "INSERT INTO ShoppingList(Name) VALUES (@Name)";
                if (stringArray.Length > 1)
                    query = "INSERT INTO ShoppingList(Name, Weight) VALUES (@Name, @Weight)";
                if (stringArray.Length > 2)
                    query = "INSERT INTO ShoppingList(Name, Weight, Price) VALUES (@Name, @Weight, @Price)";
                if (stringArray.Length > 3)
                    query = "INSERT INTO ShoppingList(Name, Weight, Price, ExpirationDate) VALUES (@Name, @Weight, @Price, @Date)";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();                 
                    command.Parameters.AddWithValue("@Name", stringArray[0]);
                    if (stringArray.Length > 1)
                        command.Parameters.AddWithValue("@Weight", stringArray[1]);
                    if (stringArray.Length > 2)
                        command.Parameters.AddWithValue("@Price", stringArray[2]);
                    if (stringArray.Length > 3)
                        command.Parameters.AddWithValue("@Date", stringArray[3]);
                    command.ExecuteScalar();
                }
                populateShopList();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Wrong inserted data", "Update",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonDeleteShopList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected row in ShoppingList?", "ShoppingList Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                string query = "Delete from ShoppingList where Id=@Id";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", shopList1.SelectedValue);

                    command.ExecuteScalar();
                }
                populateShopList();
            }
        }

        private void buttonUpdateShopListName_Click(object sender, EventArgs e)
        {
            string query = "Update ShoppingList Set Name = @Name where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textShopList.Text);
                command.Parameters.AddWithValue("@Id", shopList1.SelectedValue);

                command.ExecuteScalar();
            }
            populateShopList();
        }

        private void buttonUpdateShopListWeight_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Update ShoppingList Set Weight = @Name where Id = @Id";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", textShopList.Text);
                    command.Parameters.AddWithValue("@Id", shopList1.SelectedValue);

                    command.ExecuteScalar();
                }
                populateShopList();
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Wrong inserted data", "Update",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }           
        }

        private void buttonUpdateShopListPrice_Click(object sender, EventArgs e)
        {
            string query = "Update ShoppingList Set Price = @Name where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textShopList.Text);
                command.Parameters.AddWithValue("@Id", shopList1.SelectedValue);

                command.ExecuteScalar();
            }
            populateShopList();
        }

        private void buttonUpdateShopListDate_Click(object sender, EventArgs e)
        {
            string query = "Update ShoppingList Set ExpirationDate = @Name where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textShopList.Text);
                command.Parameters.AddWithValue("@Id", shopList1.SelectedValue);

                command.ExecuteScalar();
            }
            populateShopList();
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Ingredient(Name) VALUES (@Name)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textBox.Text);
                command.ExecuteScalar();
            }
            populateList("SELECT * FROM Ingredient", "Name", listAllIngredients);
        }

        private void buttonSearchShopList_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name,Weight,Price,ExpirationDate FROM ShoppingList WHERE Name = @Name";
            string result;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    command.Parameters.AddWithValue("@Name", textShopList.Text);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    result = "Name: " + table.Rows[0][0].ToString() + "\n" + "Weight: " + table.Rows[0][1].ToString() + "\n" + "Price: " + table.Rows[0][2].ToString() + "\n" + "ExpirationDate: " + table.Rows[0][3].ToString();
                    MessageBox.Show(result, "Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Column name not found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void delFromRecipe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected ingredient from recipe?", "Ingredients Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                string query = "Delete from RecipeIngredient where IngredientId=(SELECT Id from Ingredient where Name = @Name) and RecipeId=@RecipeId";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    string text = listIngredients.GetItemText(listIngredients.SelectedItem);
                    command.Parameters.AddWithValue("@Name", text);
                    command.Parameters.AddWithValue("@RecipeId", listRecipe.SelectedValue);
                    command.ExecuteScalar();
                }
                populateIngredientsList("Name");
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected recipe?", "Recipe Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                string query = "Delete from Recipe where Id=@Id";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", listRecipe.SelectedValue);

                    command.ExecuteScalar();
                }
                populateRecipeList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Update Recipe Set PrepTime = @Name where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textBox.Text);
                command.Parameters.AddWithValue("@Id", listRecipe.SelectedValue);

                command.ExecuteScalar();
            }
            populateRecipeList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Update Recipe Set Instructions = @Name where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textBox.Text);
                command.Parameters.AddWithValue("@Id", listRecipe.SelectedValue);

                command.ExecuteScalar();
            }
            populateRecipeList();
        }

        private void buttonDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected ingredient?", "Ingredient Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                string query = "Delete from Ingredient where Id=@Id";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", listAllIngredients.SelectedValue);
                    try
                    {
                        command.ExecuteScalar();
                    }
                    catch(System.Data.SqlClient.SqlException)
                    {
                        string query2 = "Delete from RecipeIngredient where IngredientId=@Id";

                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            connection.Open();
                            string text = listIngredients.GetItemText(listIngredients.SelectedItem);
                            command2.Parameters.AddWithValue("@Id", listAllIngredients.SelectedValue);
                            command2.ExecuteScalar();
                        }
                        command.ExecuteScalar();
                    }
                    
                }
                populateList("SELECT * FROM Ingredient", "Name", listAllIngredients);
                populateIngredientsList("Name");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Update Ingredient Set Name = @Name where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textBox.Text);
                command.Parameters.AddWithValue("@Id", listAllIngredients.SelectedValue);

                command.ExecuteScalar();
            }
            populateIngredientsList("Name");
            populateList("SELECT * FROM Ingredient", "Name", listAllIngredients);
        }

        private void shopList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select Weight From ShoppingList where Id=@Id";
            string result;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", shopList1.SelectedValue);
                DataTable table = new DataTable();
                adapter.Fill(table);
                result = table.Rows[0][0].ToString();
            }
            int index = shopList2.FindString(result);
            if (index != -1)
                shopList2.SetSelected(index, true);

            index = shopList2.SelectedIndex;
            if (index != -1)
                shopList3.SetSelected(index, true);

            index = shopList3.SelectedIndex;
            if (index != -1)
                shopList4.SetSelected(index, true);
        }
    }
}
