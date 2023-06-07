package com.bay;
import java.util.Random;

public class EllipticCurves {
    private static Random random = new Random();
    private static String alphabeth = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
    private static int[][] points = {
            {189, 297}, {189, 454}, {192, 32}, {192, 719}, {194, 205}, {194, 546}, {197, 145}, {197, 606},
            {198, 224}, {198, 527}, {200, 30}, {200, 721}, {203, 324}, {203, 427}, {205, 372}, {205, 379},
            {206, 106}, {206, 645}, {209, 82}, {209, 669}, {210, 31}, {210, 720}, {215, 247}, {215, 504},
            {218, 150}, {218, 601}, {221, 138}, {221, 613}, {226, 9}, {226, 742}, {227, 299}, {227, 542}
    };

    public static int[] inversePoint(int[] P) {
        return new int[]{P[0], (-1) * P[1]};
    }

    private static int calculateLambda(int[] P, int a, int p) {
        return GCD.mod(GCD.mod(3 * (P[0] * P[0]) + a, p) * GCD.modInverse(2 * P[1], p), p);
    }

    private static int calculateLambda(int[] P, int[] Q, int p) {
        int a = GCD.mod(GCD.mod(Q[1] - P[1], p) * GCD.mod(GCD.modInverse(Q[0] + GCD.mod(-P[0], p), p), p), p);
        return a;
    }

    public static int[] calculateSum(int[] P, int[] Q, int p) {
        int lambda = calculateLambda(P, Q, p);
        int x = GCD.mod(lambda * lambda - P[0] - Q[0], p);
        int y = GCD.mod(lambda * (P[0] - x) - P[1], p);
        return new int[]{x, y};
    }

    public static int[] calculateSum(int[] P, int a, int p) {
        int lambda = calculateLambda(P, a, p);
        int x = GCD.mod(lambda * lambda - P[0] - P[0], p);
        int y = GCD.mod(lambda * (P[0] - x) - P[1], p);
        return new int[]{x, y};
    }

    public static int[] kP(int k, int[] P, int a, int p) {
        int[] kP = P;
        for (int i = 0; i < (int) Math.log(k) / Math.log(2); i++)
            kP = calculateSum(kP, a, p);
        k = k - (int) Math.pow(2, (int) Math.log(k) / Math.log(2));
        while (k > 1) {
            for (int i = 0; i < (int) Math.log(k) / Math.log(2); i++)
                kP = calculateSum(kP, calculateSum(P, a, p), p);
            k = k - (int) Math.pow(2, (int) Math.log(k) / Math.log(2));
        }
        if (k == 1) kP = calculateSum(kP, P, p);
        return kP;
    }

    public static int[][] encrypt(String text, int[] G, int a, int p, int d) {
        int[] Q = kP(d, G, a, p);
        int[][] encryptedText = new int[text.length()][4];
        System.out.println("G = (" + G[0] + ", " + G[1] + "), d = " + d + ", Q = (" + Q[0] + ", " + Q[1] + ")");
        for (int i = 0; i < text.length(); i++) {
            int k = random.nextInt(d - 2) + 2;
            int[] P = points[alphabeth.indexOf(text.charAt(i))];
            int[] C1 = kP(k, G, a, p);
            int[] kQ = kP(k, Q, a, p);
            int[] C2 = calculateSum(P, kQ, p);
            encryptedText[i][0] = C1[0];
            encryptedText[i][1] = C1[1];
            encryptedText[i][2] = C2[0];
            encryptedText[i][3] = C2[1];
        }
        return encryptedText;
    }

    public static String decrypt(int[][] encryptedText, int a, int p, int d) {
        StringBuilder decryptedText = new StringBuilder();
        for (int i = 0; i < encryptedText.length; i++) {
            int[] C1 = kP(d, new int[]{encryptedText[i][0], encryptedText[i][1]}, a, p);
            int[] C2 = {encryptedText[i][2], encryptedText[i][3]};
            int[] P = calculateSum(C2, inversePoint(C1), p);
            for (int k = 0; k < points.length; k++) {
                if (points[k][0] == P[0] && points[k][1] == P[1]) {
                    decryptedText.append(alphabeth.charAt(k));
                    break;
                }
            }
        }
        return decryptedText.toString();
    }

    public static int[] createDigitalSign(int[] G, int q, int d, int a, int p) {
        System.out.println("G = (" + G[0] + ", " + G[1] + "), d = " + d + ", q = " + q);
        int[] digitalSign = new int[2];
        int[] kG;
        int k, t;
        do {
            do {
                k = random.nextInt(q - 2) + 2;
                kG = kP(k, G, a, p);
                digitalSign[0] = kG[0] % q;
            } while (digitalSign[0] <= 1);
            t = GCD.modInverse(k, q);
            int H = points[alphabeth.indexOf("н")][0] % 13;
            digitalSign[1] = (t * (H + d * digitalSign[0])) % q;
        } while (digitalSign[1] <= 0);
        return digitalSign;
    }

    public static boolean verifyDigitalSign(int[] digitalSign, int[] G, int q, int d, int a, int p) {
        if (digitalSign[0] <= 1 || digitalSign[1] >= q)
            return false;

        int H = points[alphabeth.indexOf("н")][0] % 13;

        int w = GCD.modInverse(digitalSign[1], q);
        int u1 = (w * H) % q;
        int u2 = (w * digitalSign[0]) % q;
        int[] Q = kP(d, G, a, p);
        int[] u1G = kP(u1, G, a, p);
        int[] u2Q = kP(u2, Q, a, p);
        int v = calculateSum(u1G, u2Q, p)[0] % q;
        return digitalSign[0] == v;
    }
}

