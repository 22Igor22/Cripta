package bay.desktop.firstdesktop;

import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Workbook;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Hashtable;
import java.util.Map;

public class CryptoMethods {
    public static String alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    public static Sheet sheet;
    public static Workbook book;
    public static void createBook(){
        book = new XSSFWorkbook();
        sheet = book.createSheet("test");
    }
    public static void writeInBook() throws IOException {
        book.write(new FileOutputStream("Chances.xlsx"));

    }
    public static void closeBook() throws IOException {
        book.close();
    }
    public static void MakeRecord(int r1, int r2, int r3, String head, String text){
        Row name = sheet.createRow(r1);
        Cell method = name.createCell(0);
        method.setCellValue(head);
        Row row = sheet.createRow(r2);
        Row row2 = sheet.createRow(r3);
        int count = 0;
        Map<Character, Integer> dict = new Hashtable<>(alphabet.length());
        for (char x:
                alphabet.toCharArray()) {
            dict.put(x, 0);
        }
        for(int i = 0; i < alphabet.length(); i++) {
            for (int j = 0; j < text.length(); j++) {
                if (alphabet.charAt(i) == text.charAt(j)) {
                    dict.put(alphabet.charAt(i), dict.get(alphabet.charAt(i)).intValue() + 1);
                }
            }
        }
        Map<Character, Double> chances = new Hashtable<>(alphabet.length());

        for (int i = 0; i < dict.size(); i++)
        {
            chances.put(alphabet.charAt(i),((double)dict.get(alphabet.charAt(i)) / (double)text.length()));
        }
        for(Character key : chances.keySet()){
            Cell letter = row.createCell(count);
            letter.setCellValue(key.toString());
            Cell chance = row2.createCell(count++);
            chance.setCellValue(chances.get(key));
        }
    }
    public static void CesarEncrypt(TextArea text, TextArea result, int a, int b, Label time) {
        long start = System.currentTimeMillis();
        String res = "";
        for (int i = 0; i < text.getText().length(); i++) {
            if (alphabet.indexOf(text.getText().charAt(i)) == -1) {
                res += text.getText().charAt(i);
            } else {
                int alphaIndex = alphabet.indexOf(text.getText().charAt(i));
                int troublesome = (a * alphaIndex + b) % alphabet.length();
                res += alphabet.charAt(troublesome);
            }
        }
        long finish = System.currentTimeMillis();
        long elapsed = finish - start;
        time.setText(elapsed + "мс");
        result.setText(res);
        MakeRecord(0,1,2, "CesarEncrypt", res);
    }

    public static void CesarDecrypt(TextArea text, TextArea result, int a, int b, Label time) {
        long start = System.currentTimeMillis();
        String res = "";
        a %= alphabet.length();
        int invert = 0; //обратное к a число по модулю N
        for (int j = 1; j < alphabet.length(); j++) {
            if ((a * j) % alphabet.length() == 1) {
                invert = j;
            }
        }

        for (int i = 0; i < text.getText().length(); i++) {
            if (alphabet.indexOf(text.getText().charAt(i)) == -1) {
                res += text.getText().charAt(i);
            } else {
                int alphaIndex = alphabet.indexOf(text.getText().charAt(i));
                int troublesome = (invert * (alphaIndex - b)) % alphabet.length();
                if (troublesome < 0) {
                    troublesome += alphabet.length();
                }
                res += alphabet.charAt(troublesome);
            }
        }
        long finish = System.currentTimeMillis();
        long elapsed = finish - start;
        time.setText(elapsed + "мс");
        result.setText(res);
        MakeRecord(4,5,6, "CesarDecrypt", res);
    }

    public static void VigenereEncrypt(TextArea text, TextArea result, String key, Label time) {
        long start = System.currentTimeMillis();
        int[] keyValue = new int[key.length()];

        for (int i = 0; i < key.length(); i++) {
            keyValue[i] = alphabet.indexOf(key.charAt(i));
        }

        String res = "";
        int pointer = 0;

        for (int i = 0; i < text.getText().length(); i++) {
            if (alphabet.indexOf(text.getText().charAt(i)) != -1) {
                int shift = (alphabet.indexOf(text.getText().charAt(i)) + keyValue[pointer]) % alphabet.length();
                res += alphabet.charAt(shift);
                pointer += 1;
            } else {
                pointer = 0;
                res += text.getText().charAt(i);
            }

            pointer = pointer >= keyValue.length ? 0 : pointer;
        }
        long finish = System.currentTimeMillis();
        long elapsed = finish - start;
        time.setText(elapsed + "мс");
        result.setText(res);
        MakeRecord(8,9,10, "VigenereEncrypt", res);
    }

    public static void VigenereDecrypt(TextArea text, TextArea result, String key, Label time) {
        long start = System.currentTimeMillis();
        int[] keyValue = new int[key.length()];

        for (int i = 0; i < key.length(); i++) {
            keyValue[i] = alphabet.indexOf(key.charAt(i));
        }

        String res = "";
        int pointer = 0;

        for (int i = 0; i < text.getText().length(); i++) {
            if (alphabet.indexOf(text.getText().charAt(i)) != -1) {
                int shift = alphabet.indexOf(text.getText().charAt(i)) - keyValue[pointer];
                if (shift < 0) {
                    res += alphabet.charAt(alphabet.length() - Math.abs(shift));
                } else {
                    res += alphabet.charAt(Math.abs(shift));
                }
                pointer += 1;
            } else {
                pointer = 0;
                res += text.getText().charAt(i);
            }

            pointer = pointer >= keyValue.length ? 0 : pointer;
        }
        long finish = System.currentTimeMillis();
        long elapsed = finish - start;
        time.setText(elapsed + "мс");
        result.setText(res);
        MakeRecord(12,13,14, "VigenereDecrypt", res);
    }
}
