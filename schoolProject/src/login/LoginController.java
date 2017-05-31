package login;

import admin.AdminController;
import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.stage.Stage;
import students.StudentsController;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

/**
 * Created by pawel on 14.04.2017.
 */
public class LoginController implements Initializable{

    LoginModel loginModel = new LoginModel();
    @FXML
    private Label dbStatus, loginStatusLbl;
    @FXML
    private TextField username;
    @FXML
    private PasswordField password;
    @FXML
    private ComboBox<role> role;
    @FXML
    private Button loginButton;

    public void initialize(URL url, ResourceBundle rb){
        this.role.setItems(FXCollections.observableArrayList(login.role.values()));
    }


    @FXML
    public void login(ActionEvent event){
        try {
            if (true)
//            if (this.loginModel.checkLoginData(
//                    this.username.getText(),
//                    this.password.getText(),
//                    ((role)this.role.getValue()).toString()
//            ))
            {
                Stage stage = (Stage)this.loginButton.getScene().getWindow();
                stage.close();

                switch ( ((role)this.role.getValue()).toString() )
                {
                    case "Admin":
                        adminLogin();
                        break;
                }
            } else {
                this.loginStatusLbl.setText("Błędne dane");
            }

        }catch (Exception localException){
            localException.printStackTrace();
        }
    }

    public void adminLogin(){
        try{
            Stage adminStage = new Stage();
            FXMLLoader adminLoader = new FXMLLoader();
            Pane adminroot = (Pane)adminLoader.load(getClass().getResource("/admin/adminFXML.fxml").openStream());
            AdminController adminController = (AdminController)adminLoader.getController();

            Scene scene = new Scene(adminroot);
            adminStage.setScene(scene);
            adminStage.setTitle("Panel Admina");
            adminStage.setResizable(false);
            adminStage.show();
        } catch (IOException e) {
            System.out.println("AdminLogin() ex");
            e.printStackTrace();
        }
    }

    @FXML
    public void exitProgram(){
        System.exit(0);
    }

}
