package pha_ma.b2;

import java.io.*;
import java.util.Scanner;

public class A51Cipher {
    private int[] X = new int[19];  // LFSR X
    private int[] Y = new int[22];  // LFSR Y
    private int[] Z = new int[23];  // LFSR Z

    // Khởi tạo ba thanh ghi với khóa ban đầu
    public void initializeRegisters(int[] xKey, int[] yKey, int[] zKey) {
        System.arraycopy(xKey, 0, X, 0, 19);
        System.arraycopy(yKey, 0, Y, 0, 22);
        System.arraycopy(zKey, 0, Z, 0, 23);
    }

    // Hàm này thực hiện phép XOR để tạo ra bit khóa từ ba thanh ghi
    private int getKeyStreamBit() {
        int majority = majorityVote(X[8], Y[10], Z[10]);

        if (X[8] == majority) {
            stepLFSR(X, new int[]{13, 16, 17, 18});
        }
        if (Y[10] == majority) {
            stepLFSR(Y, new int[]{20, 21});
        }
        if (Z[10] == majority) {
            stepLFSR(Z, new int[]{7, 20, 21, 22});
        }

        return X[18] ^ Y[21] ^ Z[22];
    }

    // Hàm đa số (majority vote)
    private int majorityVote(int bit1, int bit2, int bit3) {
        return (bit1 + bit2 + bit3) > 1 ? 1 : 0;
    }

    // Thực hiện dịch thanh ghi theo các vị trí tap
    private void stepLFSR(int[] lfsr, int[] taps) {
        int newBit = 0;
        for (int tap : taps) {
            newBit ^= lfsr[tap];
        }
        System.arraycopy(lfsr, 0, lfsr, 1, lfsr.length - 1);
        lfsr[0] = newBit;
    }

    // Mã hóa hoặc giải mã file dựa trên chế độ (encrypt hoặc decrypt)
    public void processFile(String inputFile, String outputFile, String mode) throws IOException {
        try (FileInputStream fis = new FileInputStream(inputFile);
             FileOutputStream fos = new FileOutputStream(outputFile)) {
            int data;
            while ((data = fis.read()) != -1) {
                int keyStreamBit = getKeyStreamBit();
                fos.write(data ^ keyStreamBit);  // Thực hiện XOR với bit khóa
            }
        }
        System.out.println(mode.equals("e") ? "Mã hóa hoàn tất!" : "Giải mã hoàn tất!");
    }

    // Chuyển chuỗi bit từ string thành mảng int
    public int[] convertKeyToBitArray(String key, int size) {
        int[] bitArray = new int[size];
        for (int i = 0; i < key.length() && i < size; i++) {
            bitArray[i] = key.charAt(i) == '1' ? 1 : 0;
        }
        return bitArray;
    }

    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Chọn chế độ (e để mã hóa, d để giải mã): ");
        String mode = scanner.nextLine();

        System.out.println("Nhập khóa X (19 bit): ");
        String xKey = scanner.nextLine();
        System.out.println("Nhập khóa Y (22 bit): ");
        String yKey = scanner.nextLine();
        System.out.println("Nhập khóa Z (23 bit): ");
        String zKey = scanner.nextLine();

        A51Cipher cipher = new A51Cipher();
        cipher.initializeRegisters(
                cipher.convertKeyToBitArray(xKey, 19),
                cipher.convertKeyToBitArray(yKey, 22),
                cipher.convertKeyToBitArray(zKey, 23)
        );

        System.out.println("Nhập tên file đầu vào: ");
        String inputFile = scanner.nextLine();
        System.out.println("Nhập tên file đầu ra: ");
        String outputFile = scanner.nextLine();

        cipher.processFile(inputFile, outputFile, mode);
    }
}
