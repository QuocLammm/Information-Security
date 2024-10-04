package pha_ma.b1;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.NoSuchFileException;
import java.util.Scanner;

class CaesarCipherFile {

    // Hàm Caesar Cipher
    public static String caesarCipher(String plainText, int key) {
        int n = plainText.length();
        StringBuilder cipherText = new StringBuilder();
        int root;

        for (int i = 0; i < n; i++) {
            char currentChar = plainText.charAt(i);

            if (currentChar >= 'a' && currentChar <= 'z')
                root = 'a';
            else if (currentChar >= 'A' && currentChar <= 'Z')
                root = 'A';
            else
                root = 0;

            if (root != 0) {
                int asc = currentChar - root;
                asc = (26 + asc + key) % 26;  // Thêm 26 để tránh giá trị âm khi key là số âm.
                cipherText.append((char) (asc + root));
            } else {
                cipherText.append(currentChar);
            }
        }
        return cipherText.toString();
    }

    public static void main(String[] args) {
        try (Scanner scanner = new Scanner(System.in)) {
            System.out.print("Nhập 'e' để mã hóa hoặc 'd' để giải mã: ");
            char type = scanner.next().charAt(0);

            // Nhập khóa
            System.out.print("Nhập key (số nguyên): ");
            int key = scanner.nextInt();

            // Nhập tên file nguồn
            System.out.print("Nhập đường dẫn tới file nguồn: ");
            String srcFile = scanner.next();


            // Nhập tên file đích
            System.out.print("Nhập đường dẫn tới file đích: ");
            String destFile = scanner.next();

            System.out.println("\nCEASAR FILE ENCRYPTION & DECRYPTION");
            System.out.println("Type: " + type);
            System.out.println("Key: " + key);
            System.out.println("Source file: " + srcFile);
            System.out.println("Destination file: " + destFile);

            // Kiểm tra file nguồn có tồn tại không
            if (!Files.exists(Paths.get(srcFile))) {
                System.err.println("File không tồn tại: " + srcFile);
                return;
            }

            // Đọc file nguồn
            String content = new String(Files.readAllBytes(Paths.get(srcFile)));
            String[] lines = content.split("\\R");  // Tách các dòng theo các ký tự xuống dòng

            try (BufferedWriter writer = new BufferedWriter(new FileWriter(destFile))) {
                for (String line : lines) {
                    String encryptedOrDecryptedLine = (type == 'e')
                            ? caesarCipher(line, key)
                            : caesarCipher(line, -key);

                    writer.write(encryptedOrDecryptedLine);
                    writer.newLine();
                }
            }

            // Thông báo thành công
            if (type == 'e') {
                System.out.println("Encryption successful.");
            } else {
                System.out.println("Decryption successful.");
            }

        } catch (NoSuchFileException e) {
            System.err.println("Không thể mở File: " + e.getMessage());
        } catch (IOException e) {
            System.err.println("Lỗi ở đọc hoặc chép File.");
            e.printStackTrace();
        }
    }
}