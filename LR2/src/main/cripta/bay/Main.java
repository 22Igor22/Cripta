package cripta.bay;

import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Workbook;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.openxmlformats.schemas.spreadsheetml.x2006.main.WorkbookDocument;
import org.openxmlformats.schemas.spreadsheetml.x2006.main.impl.WorkbookDocumentImpl;

import java.io.FileOutputStream;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.*;

public class Main {
    static List<Character> binList = new ArrayList<>();

    public static void main(String[] args) throws IOException {

        Scanner in = new Scanner(System.in);
        binList.add(0, '1');binList.add(1, '0');
        int choice = 1;
        Character [] Letters = {
                'a','ă','â','b','c','d','e','f','g','h','i',
                'î','j','k','l','m','n','o','p','q','r','s',
                'ș', 't', 'ț', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        List<Character> romanianAlphabet = new ArrayList<>(Arrays.asList(Letters));

        Character [] Letters2 = {
                '\u0430','\u0431','\u0432','\u0433','\u0434','\u0452',
                '\u0435','\u0436','\u0437','\u0438','\u0458','\u043A',
                '\u043B','\u0459','\u043C','\u043D','\u045A','\u043E',
                '\u043F','\u0440','\u0441','\u0442','\u045B','\u0443',
                '\u0444','\u0445','\u0446','\u0447','\u045F','\u0448'
        };
        List<Character> serbianAlphabet = new ArrayList<>(Arrays.asList(Letters2));

        EntropyMethotds Romanian = new EntropyMethotds();
        EntropyMethotds Serbian = new EntropyMethotds();
        EntropyMethotds RomanianBin = new EntropyMethotds();
        EntropyMethotds SerbianBin = new EntropyMethotds();

        while (choice != 0)
        {
            System.out.println("Выберите номер задания:\n- 1\n- 2\n- 3\n- 4\n- 0-выйти");
            choice = in.nextInt();
            switch (choice)
            {
                case 1:
                {
                    EntropyMethotds romanianMethods = new EntropyMethotds(romanianAlphabet, 0, "Румынский");
                    EntropyMethotds serbianMethods = new EntropyMethotds(serbianAlphabet, 0, "Сербский");

                    String romanianText = new String(Files.readAllBytes(Paths.get("D:\\University\\3Course\\2sem\\Cripta\\LR2\\romanian.txt")));
                    String serbianText = new String(Files.readAllBytes(Paths.get("D:\\University\\3Course\\2sem\\Cripta\\LR2\\serbian.txt")));

                    romanianText = romanianText.replaceAll("\\P{L}+", "");
                    serbianText = serbianText.replaceAll("\\P{L}+", "");

                    Map<Character, Integer> romanianDict = romanianMethods.alphabetListToDictionary();
                    Map<Character, Integer> serbianDict = serbianMethods.alphabetListToDictionary();

                    romanianMethods.getCounts(romanianText, romanianDict);
                    serbianMethods.getCounts(serbianText, serbianDict);

                    Map<Character, Double> chancesRomanian = romanianMethods.getChances(romanianText, romanianDict);
                    Map<Character, Double> chancesSerbian = serbianMethods.getChances(serbianText, serbianDict);

                    romanianMethods.getTextEntropy(chancesRomanian);
                    serbianMethods.getTextEntropy(chancesSerbian);


                    romanianMethods.printAlphabet();
                    romanianMethods.printChances(chancesRomanian);
                    romanianMethods.printEntropy();


                    serbianMethods.printAlphabet();
                    serbianMethods.printChances(chancesSerbian);
                    serbianMethods.printEntropy();

                    Romanian = romanianMethods;
                    Serbian = serbianMethods;

                    Workbook book = new XSSFWorkbook();
                    Sheet sheet = book.createSheet("test");
                    Row name = sheet.createRow(0);
                    Cell alphabet = name.createCell(0);
                    alphabet.setCellValue(romanianMethods.alphabetName);
                    Row row = sheet.createRow(1);
                    Row row2 = sheet.createRow(2);
                    int count = 0;
                    for(Character key : chancesRomanian.keySet()){
                        Cell letter = row.createCell(count);
                        letter.setCellValue(key.toString());
                        Cell chance = row2.createCell(count++);
                        chance.setCellValue(chancesRomanian.get(key));
                    }
                    Row name2 = sheet.createRow(4);
                    Cell alphabet2 = name2.createCell(0);
                    alphabet2.setCellValue(serbianMethods.alphabetName);
                    Row row3 = sheet.createRow(5);
                    Row row4 = sheet.createRow(6);
                    count = 0;
                    for(Character key : chancesSerbian.keySet()){
                        Cell letter = row3.createCell(count);
                        letter.setCellValue(key.toString());
                        Cell chance = row4.createCell(count++);
                        chance.setCellValue(chancesSerbian.get(key));
                    }

                    book.write(new FileOutputStream("Chances.xlsx"));
                    book.close();
                    break;
                }
                case 2:
                {
                    EntropyMethotds romanianChecker = new EntropyMethotds(binList, 0, "Бинарный (румынский)");
                    EntropyMethotds serbianChecker = new EntropyMethotds(binList, 0, "Бинарный (сербский)");

                    String romanianText = new String(Files.readAllBytes(Paths.get("D:\\University\\3Course\\2sem\\Cripta\\LR2\\romanian.txt")));
                    String serbianText = new String(Files.readAllBytes(Paths.get("D:\\University\\3Course\\2sem\\Cripta\\LR2\\serbian.txt")));

                    romanianText = romanianText.replaceAll("\\P{L}+", "");
                    serbianText = serbianText.replaceAll("\\P{L}+", "");

                    String binTextRomanian = "";
                    String binTextSerbian = "";

                    var textChr = romanianText.getBytes(StandardCharsets.UTF_8);
                    for (int chr : textChr)
                    {
                        var str = String.format("%8s", Integer.toBinaryString(chr)).replaceAll(" ", "0");
                        binTextRomanian += str.substring(str.length()-8, str.length());
                    }

                    textChr = serbianText.getBytes(StandardCharsets.UTF_8);
                    for (int chr : textChr)
                    {
                        var str = String.format("%8s", Integer.toBinaryString(chr)).replaceAll(" ", "0");
                        binTextSerbian += str.substring(str.length()-8, str.length());
                    }

                    Map<Character, Integer> romanianDict = romanianChecker.alphabetListToDictionary();
                    Map<Character, Integer> serbianDict = serbianChecker.alphabetListToDictionary();

                    romanianChecker.getCounts(binTextRomanian, romanianDict);
                    serbianChecker.getCounts(binTextSerbian, serbianDict);

                    Map<Character, Double> chancesRomanian = romanianChecker.getChances(binTextRomanian, romanianDict);
                    Map<Character, Double> chancesSerbian = serbianChecker.getChances(binTextSerbian, serbianDict);

                    romanianChecker.getTextEntropy(chancesRomanian);
                    serbianChecker.getTextEntropy(chancesSerbian);

                    romanianChecker.printAlphabet();
                    romanianChecker.printChances(chancesRomanian);
                    romanianChecker.printEntropy();

                    serbianChecker.printAlphabet();
                    serbianChecker.printChances(chancesSerbian);
                    serbianChecker.printEntropy();

                    RomanianBin = romanianChecker;
                    SerbianBin = serbianChecker;
                    break;
                }
                case 3:
                {

                    EntropyMethotds romanianChecker = new EntropyMethotds(romanianAlphabet, 0, "Румынский");
                    EntropyMethotds serbianChecker = new EntropyMethotds(serbianAlphabet, 0, "Сербский");
                    EntropyMethotds romanianCheckerBin = new EntropyMethotds(binList, 0, "Бинарный код (румынский)");
                    EntropyMethotds serbianCheckerBin = new EntropyMethotds(binList, 0, "Бинарный код (сербский)");

                    romanianChecker = Romanian;
                    serbianChecker = Serbian;
                    romanianCheckerBin = RomanianBin;
                    serbianCheckerBin = SerbianBin;

                    String romanianText = "bayigoriolegovich";
                    String serbianText = "баиигориолеговицх";

                    String binTextRomanian = "";
                    String binTextSerbian = "";

                    var textChr = romanianText.toString().getBytes(StandardCharsets.UTF_8);
                    for (int chr : textChr)
                    {
                        var str = String.format("%8s", Integer.toBinaryString(chr)).replaceAll(" ", "0");
                        binTextRomanian += str.substring(str.length()-8, str.length());
                    }

                    textChr = serbianText.toString().getBytes(StandardCharsets.UTF_8);
                    for (int chr : textChr)
                    {
                        var str = String.format("%8s", Integer.toBinaryString(chr)).replaceAll(" ", "0");
                        binTextSerbian += str.substring(str.length()-8, str.length());
                    }

                    System.out.println(romanianText);
                    System.out.println(binTextRomanian);
                    System.out.println('\n' + serbianText);
                    System.out.println(binTextSerbian);


                    romanianChecker.printEntropy();
                    serbianChecker.printEntropy();
                    romanianCheckerBin.printEntropy();
                    serbianCheckerBin.printEntropy();

                    System.out.println("\nЯзык - " + romanianChecker.alphabetName + ":" + romanianChecker.alphabetEntropy * romanianText.length());
                    System.out.println("Язык - " + serbianChecker.alphabetName + ":" + serbianChecker.alphabetEntropy * serbianText.length());
                    System.out.println("Язык - " + romanianCheckerBin.alphabetName + ":" + romanianCheckerBin.alphabetEntropy * binTextRomanian.length());
                    System.out.println("Язык - " + serbianCheckerBin.alphabetName + ":" + serbianCheckerBin.alphabetEntropy * binTextSerbian.length());
                    break;
                }
                case 4:
                {

                    EntropyMethotds romanianChecker = new EntropyMethotds(romanianAlphabet, 0, "Румынский");
                    EntropyMethotds serbianChecker = new EntropyMethotds(serbianAlphabet, 0, "Сербский");
                    EntropyMethotds romanianCheckerBin = new EntropyMethotds(binList, 0, "Бинарный (румынский)");
                    EntropyMethotds serbianCheckerBin = new EntropyMethotds(binList, 0, "Бинарный (сербский)");


                    String romanianText = "bayigoriolegovich";
                    String serbianText = "баиигориолеговицх";

                    String binTextRomanian = "";
                    String binTextSerbian = "";

                    var textChr = romanianText.toString().getBytes(StandardCharsets.UTF_8);
                    for (int chr : textChr)
                    {
                        var str = String.format("%8s", Integer.toBinaryString(chr)).replaceAll(" ", "0");
                        binTextRomanian += str.substring(str.length()-8, str.length());
                    }

                    textChr = serbianText.toString().getBytes(StandardCharsets.UTF_8);
                    for (int chr : textChr)
                    {
                        var str = String.format("%8s", Integer.toBinaryString(chr)).replaceAll(" ", "0");
                        binTextSerbian += str.substring(str.length()-8, str.length());
                    }

                    Map<Character, Integer> romanianDict = romanianChecker.alphabetListToDictionary();
                    Map<Character, Integer> serbianDict = serbianChecker.alphabetListToDictionary();
                    Map<Character, Integer> romanianDictBin = romanianCheckerBin.alphabetListToDictionary();
                    Map<Character, Integer> serbianDictBin = serbianCheckerBin.alphabetListToDictionary();

                    romanianChecker.getCounts(romanianText, romanianDict);
                    serbianChecker.getCounts(serbianText, serbianDict);
                    romanianCheckerBin.getCounts(binTextRomanian, romanianDictBin);
                    serbianCheckerBin.getCounts(binTextSerbian, serbianDictBin);

                    Map<Character, Double> chancesRomanian = romanianChecker.getChances(romanianText, romanianDict);
                    Map<Character, Double> chancesSerbian = serbianChecker.getChances(serbianText, serbianDict);

                    System.out.println("Ошибка = 0.1. Язык - " + romanianCheckerBin.alphabetName + ":" + romanianCheckerBin.getTextEntropyWithErrorForBin(binTextRomanian, 0.1));
                    System.out.println("Ошибка = 0.5. Язык - " + romanianCheckerBin.alphabetName + ":" + romanianCheckerBin.getTextEntropyWithErrorForBin(binTextRomanian, 0.5));
                    System.out.println("Ошибка = 0.9. Язык - " + romanianCheckerBin.alphabetName + ":" + romanianCheckerBin.getTextEntropyWithErrorForBin(binTextRomanian, 0.999999999));

                    System.out.println("Ошибка = 0.1. Язык - " + serbianCheckerBin.alphabetName + ":" + serbianCheckerBin.getTextEntropyWithErrorForBin(binTextSerbian, 0.1));
                    System.out.println("Ошибка = 0.5. Язык - " + serbianCheckerBin.alphabetName + ":" + serbianCheckerBin.getTextEntropyWithErrorForBin(binTextSerbian, 0.5));
                    System.out.println("Ошибка = 0.9. Язык - " + serbianCheckerBin.alphabetName + ":" + serbianCheckerBin.getTextEntropyWithErrorForBin(binTextSerbian, 0.999999999));

                    System.out.println("Ошибка = 0.1. Язык - " + romanianChecker.alphabetName + ":" + romanianChecker.getTextEntropyWithError(romanianText, chancesRomanian,0.1));
                    System.out.println("Ошибка = 0.5. Язык - " + romanianChecker.alphabetName + ":" + romanianChecker.getTextEntropyWithError(romanianText, chancesRomanian,0.5));
                    System.out.println("Ошибка = 0.9. Язык - " + romanianChecker.alphabetName + ":" + romanianChecker.getTextEntropyWithError(romanianText, chancesRomanian,0.999999999));

                    System.out.println("Ошибка = 0.1. Язык - " + serbianChecker.alphabetName + ":" + serbianChecker.getTextEntropyWithError(serbianText, chancesSerbian,0.1));
                    System.out.println("Ошибка = 0.5. Язык - " + serbianChecker.alphabetName + ":" + serbianChecker.getTextEntropyWithError(serbianText, chancesSerbian,0.5));
                    System.out.println("Ошибка = 0.9. Язык - " + serbianChecker.alphabetName + ":" + serbianChecker.getTextEntropyWithError(serbianText, chancesSerbian,0.999999999));
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
}