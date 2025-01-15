using System;
using System.Security.Cryptography;
using System.Text;
using UserManager;
namespace UserManager;
public class PasswordHasher : IPasswordHasher
{
    private const int SaltSize = 16; // Размер соли (в байтах)
    private const int HashSize = 32; // Размер хэша (в байтах)
    private const int Iterations = 10000; // Количество итераций

    public string HashPassword(string password)
    {
        // Создание соли
        using var rng = RandomNumberGenerator.Create();
        var salt = new byte[SaltSize];
        rng.GetBytes(salt);

        // Генерация хэша
        var hash = GenerateHash(password, salt);

        // Возврат соли и хэша в виде строки (Base64)
        return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        // Разделение строки на соль и хэш
        var parts = hashedPassword.Split(':');
        if (parts.Length != 2)
            return false;

        var salt = Convert.FromBase64String(parts[0]);
        var hash = Convert.FromBase64String(parts[1]);

        // Генерация нового хэша с той же солью
        var hashToCompare = GenerateHash(password, salt);

        // Сравнение хэшей
        return CryptographicOperations.FixedTimeEquals(hash, hashToCompare);
    }

    private byte[] GenerateHash(string password, byte[] salt)
    {
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(HashSize);
    }
}