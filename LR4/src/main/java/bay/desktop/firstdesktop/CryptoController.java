package bay.desktop.firstdesktop;

import javafx.fxml.FXML;
import javafx.scene.control.Label;

public class CryptoController {
    @FXML
    private Label welcomeText;

    @FXML
    protected void onHelloButtonClick() {
        welcomeText.setText("Welcome to JavaFX Application!");
    }
}