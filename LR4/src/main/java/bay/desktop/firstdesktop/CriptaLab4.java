package bay.desktop.firstdesktop;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.geometry.Orientation;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ScrollPane;
import javafx.scene.control.TextArea;
import javafx.scene.layout.*;
import javafx.stage.Stage;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

public class CriptaLab4 extends Application {
    @Override
    public void start(Stage stage) throws IOException {
        GridPane gridPane = new GridPane();
        gridPane.setAlignment(Pos.CENTER);
        ColumnConstraints column1 = new ColumnConstraints();
        column1.setPercentWidth(40);
        gridPane.getColumnConstraints().add(column1);
        ColumnConstraints column2 = new ColumnConstraints();
        column1.setPercentWidth(20);
        gridPane.getColumnConstraints().add(column2);
        ColumnConstraints column3 = new ColumnConstraints();
        column1.setPercentWidth(40);
        gridPane.getColumnConstraints().add(column3);
        gridPane.getRowConstraints().add(new RowConstraints(400));
        gridPane.getRowConstraints().add(new RowConstraints(400));
        gridPane.getRowConstraints().add(new RowConstraints(400));

        ScrollPane scrollPanel = new ScrollPane(gridPane);
        scrollPanel.setFitToHeight(true);
        scrollPanel.setFitToWidth(true);

        TextArea textCesar = new TextArea();
        TextArea resultCesar = new TextArea();
        TextArea textVigenere = new TextArea();
        TextArea resultVigenere = new TextArea();

        textCesar.setText(new String(Files.readAllBytes(Paths.get("D:\\University\\3Course\\2sem\\Cripta\\LR4\\text.txt"))));
        textVigenere.setText(new String(Files.readAllBytes(Paths.get("D:\\University\\3Course\\2sem\\Cripta\\LR4\\text.txt"))));

        Label cesarTime = new Label();
        Label vigenereTime = new Label();

        Button encryptCesar = new Button("Encrypt");
        Button decryptCesar = new Button("Decrypt");
        Button encryptVigenere = new Button("Encrypt");
        Button decryptVigenere = new Button("Decrypt");
        VBox cesarBox = new VBox(10, encryptCesar, decryptCesar, cesarTime);
        cesarBox.setAlignment(Pos.CENTER);
        VBox vigenereBox = new VBox(10, encryptVigenere, decryptVigenere, vigenereTime);
        vigenereBox.setAlignment(Pos.CENTER);

        gridPane.add(textCesar, 0, 0);
        gridPane.add(cesarBox, 1, 0);
        gridPane.add(resultCesar, 2, 0);
        gridPane.add(textVigenere, 0, 1);
        gridPane.add(vigenereBox, 1, 1);
        gridPane.add(resultVigenere, 2, 1);

        encryptCesar.setOnAction(event -> CryptoMethods.CesarEncrypt(textCesar, resultCesar, 7, 10, cesarTime));
        decryptCesar.setOnAction(event -> CryptoMethods.CesarDecrypt(textCesar, resultCesar, 7, 10, cesarTime));
        encryptVigenere.setOnAction(event -> CryptoMethods.VigenereEncrypt(textVigenere, resultVigenere, "игорь", vigenereTime));
        decryptVigenere.setOnAction(event -> CryptoMethods.VigenereDecrypt(textVigenere, resultVigenere, "игорь", vigenereTime));

        stage.setTitle("LR4");
        stage.setScene(new Scene(scrollPanel, 1400, 700));
        stage.show();
    }

    public static void main(String[] args) throws IOException {
        CryptoMethods.createBook();
        launch();
        CryptoMethods.writeInBook();
        CryptoMethods.closeBook();
    }
}