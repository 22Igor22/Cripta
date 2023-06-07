package bay.cripta;

import java.io.IOException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {
        int c = 0;
        Scanner in = new Scanner(System.in);
        while (true) {
            System.out.println("Введите номер задания:");
            System.out.println("1- НОД двух чисел");
            System.out.println("2- НОД трёх чисел");
            System.out.println("3- Поиск простых чисел из диапазона");
            System.out.println("4- Каноническая форма записи");
            System.out.println("5- Конкатенация m и n, проверка числа на простоту");
            c = in.nextInt();
            switch (c) {
                case 1: {
                    int x = 0, y = 0;
                    System.out.print("Введите первое число: ");
                    x = in.nextInt();
                    System.out.print("Введите второе число: ");
                    y = in.nextInt();
                    System.out.println("НОД двух чисел " + x + " " + y + " равен: " + Functions.NOD(x, y));
                    break;

                }

                case 2: {
                    int x = 0, y = 0, z = 0;
                    System.out.print("Введите первое число: ");
                    x = in.nextInt();
                    System.out.print("Введите второе число: ");
                    y = in.nextInt();
                    System.out.print("Введите третье число: ");
                    z = in.nextInt();

                    System.out.println("НОД трёх чисел " + x + " " + y + " " + z + " равен: " + Functions.NOD(z, Functions.NOD(x, y)));
                    break;

                }
                case 3: {
                    int x = 0, y = 0;
                    System.out.print("Введите первое число: ");
                    x = in.nextInt();
                    System.out.print("Введите второе число, больше первого: ");
                    y = in.nextInt();
                    Functions.findSimple(x, y);
                    if (x == 2) {
                        System.out.println("n/ln(n) = " + y / Math.log(y));
                    }
                    break;

                }
                case 4: {
                    int x = 0;
                    System.out.print("Введите число: ");
                    x = in.nextInt();
                    Functions.canonicalNotation(x);
                    break;
                }
                case 5: {
                    int x = 0, y = 0;
                    System.out.print("Введите первое число: ");
                    x = in.nextInt();
                    System.out.print("Введите второе число: ");
                    y = in.nextInt();
                    String xy = Integer.toString(x) + Integer.toString(y);
                    if (Functions.isSimple(Integer.parseInt(xy))) {
                        System.out.println(xy + " simple");
                    } else {
                        System.out.println(xy + " not simple");
                    }
                    break;
                }
                default: {
                    break;
                }
            }
        }
    }
}