﻿using Domain.Shared;
namespace Domain.Errors
{
    public static class DomainErrors
    {
        public static class Username
        {
            public static readonly Error Empty = new(
                "Username.Empty",
                "Пустое поле");

            public static readonly Error TooLong = new(
                "Username.TooLong",
                $"Поле слишком длинное. Максимальная длина {Domain.ValueObjects.Username.MAX_LENGTH} символов");

            public static readonly Error TooShort = new(
                "Username.TooShort",
                $"Поле слишком короткое. Минимальная длина {Domain.ValueObjects.Username.MAX_LENGTH} символа");
        }

        public static class Email
        {
            public static readonly Error Empty = new(
                "Email.Empty",
                "Пустое поле");

            public static readonly Error TooLong = new(
                "Email.TooLong",
                $"Поле слишком длинное. Максимальная длина {Domain.ValueObjects.Email.MAX_LENGTH} символов");

            public static readonly Error TooShort = new(
                "Email.TooShort",
                $"Поле слишком короткое. Минимальная длина {Domain.ValueObjects.Email.MIN_LENGTH} символа");

            public static readonly Error InvalidFormat = new(
                "Email.InvalidFormat",
                $"Поле имеет неправльный формат. Верный формат: example@gmail.com");
        }
        
        public static class PasswordHashed
        {
            public static readonly Error Empty = new(
                "PasswordHashed.Empty",
                "Пустое поле");

            public static readonly Error TooLong = new(
                "PasswordHashed.TooLong",
                $"Поле слишком длинное. Максимальная длина {Domain.ValueObjects.PasswordHashed.MAX_LENGTH} символов");

            public static readonly Error TooShort = new(
                "PasswordHashed.TooShort",
                $"Поле слишком короткое. Минимальная длина {Domain.ValueObjects.PasswordHashed.MAX_LENGTH} символа");
        }
    }
}
