#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#define MAX_TEXT_LEN 1000

// Function prototypes
void encrypt(char* text, char* key, char* result);
void decrypt(char* cipher, char* key, char* result);
void frequency_analysis(char* text, int freq[26]);

int main() {
    char text[MAX_TEXT_LEN], cipher[MAX_TEXT_LEN], decrypted[MAX_TEXT_LEN];
    char key[27] = "QWERTYUIOPASDFGHJKLZXCVBNM"; // Example substitution key
    int freq[26] = {0};
    int option;

    // Get user input for plain text
    printf("Enter text: ");
    fgets(text, MAX_TEXT_LEN, stdin);
    text[strcspn(text, "\n")] = 0; // Remove newline character

    printf("Choose an option:\n");
    printf("1. Encrypt text\n");
    printf("2. Decrypt cipher\n");
    printf("3. Perform frequency analysis\n");
    scanf("%d", &option);
    getchar();  // To consume newline after the integer input

    switch (option) {
        case 1:
            encrypt(text, key, cipher);
            printf("Encrypted text: %s\n", cipher);
            break;
        case 2:
            printf("Enter cipher text: ");
            fgets(cipher, MAX_TEXT_LEN, stdin);
            cipher[strcspn(cipher, "\n")] = 0;
            decrypt(cipher, key, decrypted);
            printf("Decrypted text: %s\n", decrypted);
            break;
        case 3:
            frequency_analysis(text, freq);
            printf("Letter Frequency:\n");
            for (int i = 0; i < 26; i++) {
                printf("%c: %d\n", i + 'A', freq[i]);
            }
            break;
        default:
            printf("Invalid option.\n");
            break;
    }

    return 0;
}

// Function to encrypt text using a substitution key
void encrypt(char* text, char* key, char* result) {
    int len = strlen(text);
    for (int i = 0; i < len; i++) {
        if (isalpha(text[i])) {
            char letter = toupper(text[i]);
            result[i] = key[letter - 'A'];
        } else {
            result[i] = text[i];  // Keep non-alphabet characters the same
        }
    }
    result[len] = '\0';
}

// Function to decrypt cipher text using a substitution key
void decrypt(char* cipher, char* key, char* result) {
    int len = strlen(cipher);
    for (int i = 0; i < len; i++) {
        if (isalpha(cipher[i])) {
            char letter = toupper(cipher[i]);
            for (int j = 0; j < 26; j++) {
                if (key[j] == letter) {
                    result[i] = j + 'A';
                    break;
                }
            }
        } else {
            result[i] = cipher[i];
        }
    }
    result[len] = '\0';
}

// Function to perform frequency analysis of a text
void frequency_analysis(char* text, int freq[26]) {
    int len = strlen(text);
    for (int i = 0; i < len; i++) {
        if (isalpha(text[i])) {
            char letter = toupper(text[i]);
            freq[letter - 'A']++;
        }
    }
}

