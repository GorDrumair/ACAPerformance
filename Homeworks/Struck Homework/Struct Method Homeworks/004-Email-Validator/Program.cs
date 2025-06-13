using System;

namespace EmailValidator;

class Program
{
    static void Main(string[] args)
    {
        EmailValidator emailValidator = new EmailValidator("GrmstaBrmnda@mail.ru");
        if (emailValidator.IsValidEmail())
        {
            Console.WriteLine("The email is valid.");
        }
        else
        {
            Console.WriteLine("The email is invalid.");
        }
    }
}

struct EmailValidator
{
    public string Email { get; set; }

    public EmailValidator(string email)
    {
        Email = email;
    }

    public bool IsValidEmail()
    {
        return !string.IsNullOrEmpty(Email) &&
               Email.Contains("@") &&
               Email.IndexOf('@') < Email.LastIndexOf('.') &&
               Email.IndexOf('.') > 0 &&
               Email.IndexOf('.') < Email.Length - 1;
    }
}