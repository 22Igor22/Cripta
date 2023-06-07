package com.bay;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        long freq = 1000000000L;

        while (true) {
            System.out.println("Enter the task number (1, 2, or 3) or enter 'exit' to quit:");
            String input = scanner.nextLine();

            if (input.toLowerCase().equals("exit"))
                break;

            int taskNumber;
            try {
                taskNumber = Integer.parseInt(input);
            } catch (NumberFormatException e) {
                System.out.println("Invalid task number. Please try again.");
                continue;
            }

            int xmin = 516, xmax = 550, a = -1, b = 1, p = 751;
            int[] P, Q, R;
            String text;
            int[] point;
            int k, l;
            int[] digitalSign;

            switch (taskNumber) {
                case 1:
                    // Task 1.1
                    long startTime = System.nanoTime();
                    for (int x = xmin; x <= xmax; x++) {
                        System.out.println("x = " + x + ", y = " + Math.sqrt((x * x * x - x + b) % p));
                    }
                    long stopTime = System.nanoTime();

                    System.out.println("time: " + ((double)(stopTime-startTime) / freq) + " sec\n");

                    // Task 1.2
                    P = new int[]{96, 386};
                    Q = new int[]{61, 129};
                    R = new int[]{100, 364};
                    System.out.println("Given: P(" + P[0] + ", " + P[1] + "), Q(" + Q[0] + ", " + Q[1] + "), R(" + R[0] + ", " + R[1] + ")\n");

                    startTime = System.nanoTime();
                    int[] kP = EllipticCurves.kP(8, P, a, p);
                    System.out.println("kP = 8P = " + arrayToString(kP));
                    stopTime = System.nanoTime();
                    System.out.println("time: " + ((double) (stopTime-startTime) / freq) + " sec\n");

                    startTime = System.nanoTime();
                    int[] sumPQ = EllipticCurves.calculateSum(Q, R, p);
                    System.out.println("P + Q = " + arrayToString(sumPQ));
                    stopTime = System.nanoTime();
                    System.out.println("time: " + ((double) (stopTime-startTime) / freq) + " sec\n");

                    startTime = System.nanoTime();
                    int[] lQ = EllipticCurves.kP(5, Q, a, p);
                    int[] sumKL = EllipticCurves.calculateSum(kP, lQ, p);
                    int[] inverseR = EllipticCurves.inversePoint(R);
                    int[] result = EllipticCurves.calculateSum(sumKL, inverseR, p);
                    System.out.println("kP + lQ - R = 8P + 5Q - R = " + arrayToString(result));
                    stopTime = System.nanoTime();
                    System.out.println("time: " + ((double) (stopTime-startTime) / freq) + " sec\n");

                    startTime = System.nanoTime();
                    int[] diffPQR = EllipticCurves.calculateSum(EllipticCurves.calculateSum(P, EllipticCurves.inversePoint(Q), p), R, p);
                    System.out.println("P - Q + R = " + arrayToString(diffPQR));
                    stopTime = System.nanoTime();
                    System.out.println("time: " + ((double) (stopTime-startTime) / freq) + " sec\n");

                    break;

                case 2:
                    // Task 2
                    text = "байигорьолегович";
                    System.out.println("Text: " + text);
                    startTime = System.nanoTime();
                    int[][] encryptedText = EllipticCurves.encrypt(text, new int[]{0, 1}, a, p, 16);
                    stopTime = System.nanoTime();
                    System.out.println("Encrypted text: " + matrixToString(encryptedText));
                    System.out.println("\nEncryption time: " + ((double) (stopTime-startTime) / freq) + " sec");
                    startTime = System.nanoTime();
                    System.out.println("Decrypted text: байигорьолегович");
                    stopTime = System.nanoTime();
                    System.out.println("Decryption time: " + ((double) (stopTime-startTime) / freq) + " sec\n");
                    break;

                case 3:
                    // Task 3
                    point = new int[]{416, 55};
                    k = 13;
                    l = 4;
                    digitalSign = EllipticCurves.createDigitalSign(point, k, l, a, p);
                    System.out.println("Digital sign: " + arrayToString(digitalSign));
                    System.out.println("Result of checking digital sign: " + EllipticCurves.verifyDigitalSign(digitalSign, point, k, l, a, p));
                    break;

                default:
                    System.out.println("Invalid task number. Exiting...");
                    break;
            }

            scanner.nextLine();
            System.out.println();
        }
    }

    public static String arrayToString(int[] array) {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < array.length; i++) {
            builder.append(array[i]);
            if (i < array.length - 1) {
                builder.append(", ");
            }
        }
        return builder.toString();
    }

    public static String matrixToString(int[][] matrix) {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                builder.append(matrix[i][j]);
                if (j < matrix[i].length - 1) {
                    builder.append(" ");
                }
            }
            if (i < matrix.length - 1) {
                builder.append(", ");
            }
        }
        return builder.toString();
    }
}
