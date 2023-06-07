module bay.desktop.firstdesktop {
    requires javafx.controls;
    requires javafx.fxml;
    requires org.apache.poi.poi;
    requires org.apache.poi.ooxml;

    requires com.almasb.fxgl.all;

    opens bay.desktop.firstdesktop to javafx.fxml, org.apache.poi.poi;
    exports bay.desktop.firstdesktop;
}