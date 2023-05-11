using CaesarCipherExercise;

string message = "Hello World!";

string encodedMessage = CaesarCipher.GenerateCipher(message, 2);

string decodedMessage = CaesarCipher.GenerateCipher(encodedMessage, -2);

Console.WriteLine("Original message: " + message);
Console.WriteLine("Encoded message: " + encodedMessage);
Console.WriteLine("Decoded message: " + decodedMessage);