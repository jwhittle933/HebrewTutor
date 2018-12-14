using System;

namespace HebrewTutor2.Models
{
    public static class About
    {
        private static string _name { get; set; } = "Jonathan Whittle";
        private static string _message { get; set; } = "I am a lover of all things linguistics. I began seminary in 2014 and quickly fell in love with Hebrew. I had studied Greek previously with a mentor, but we never made it far in the language. It was with Hebrew that my interest in language was piqued and I fell in love. This page is the product of many years of loving study of the Hebrew language.As a former seminary student, I saw two main dispositions toward Hebrew language study: enter with excitement, only to have it snuffed out due to the difficulties the language presents, or to avoid at all costs until the last possible minute.Clearly, neither of these are desirable options. This site is meant to bridge the gap between the classroom and personal study.";
        private static string _title { get; set; } = "About the Creator";

        public static string GetName() => _name;
        public static string GetMessage() => _message;
        public static string GetTitle() => _title;

        public static void SetName(string name) => name = _name;
        public static void SetMessage(string message) => message = _name;
        public static void SetTitle(string title) => title = _name;
    }
}
