using System;

namespace Operations_on_file_names
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Validator info = new Validator(/*".jpg", ".png", ".docx"*/);
            info.FirstExtension = ".jpg";
            info.SecondExtension = ".png";
            info.ThirdExtension = ".docx";

            string English = "These are the supported file types: .jpg, .png, .docx ";
            string Azerbaijan = "Bunlar dəstəklənən file növüdür:  .jpg, .png, .docx ";
            string Turkish = "Bunlar desteklenen dosya turudur:  .jpg, .png, .docx ";
            Console.WriteLine("choice language: English , Turkish , Azerbaijan");
            string currencyLanguage = Console.ReadLine();
            if (currencyLanguage == "English")
            {
                Console.WriteLine(English);
            }

            if (currencyLanguage == "Azerbaijan")
            {
                Console.WriteLine(Azerbaijan);
            }

            if (currencyLanguage == "Turkish")
            {
                Console.WriteLine(Turkish);
            }



            Console.WriteLine("Enter your 'File Name and Extension':");
            string fileName = Console.ReadLine() + info.FirstExtension;

            Console.WriteLine("Enter your 'Folder Name':");
            string folderName = Console.ReadLine();


        }
        class Validator
        {
            private string _firstExtension;
            private string _secondExtension;
            private string _thirdExtension;
            private string _fileName;
            private string _folderName;

            public string FirstExtension
            {
                get { return _firstExtension; }
                set { _firstExtension = value; }
            }
            public string SecondExtension
            {
                set { _secondExtension = value; }
                get { return _secondExtension; }
            }
            public string ThirdExtension
            {
                set { _thirdExtension = value; }
                get { return _thirdExtension; }
            }

            public Validator(/*string firstExtension, string secondExtension, string thirdExtension*/)
            {
                //firstExtension = _firstExtension;
                //secondExtension = _secondExtension;
                //thirdExtension = _thirdExtension;

            }
            public Validator(string fileName, string folderName)
            {
                fileName = _fileName;
                folderName = _folderName;
            }


            public string GetSecondExtension()
            {
                return _secondExtension;
            }
            public void SetSecondExtension(string secondExtension)
            {
                _secondExtension = secondExtension;
            }
            public string GetThirdExtension()
            {
                return _thirdExtension;
            }
            public void SetThirdExtension(string thirdExtension)
            {
                _thirdExtension = thirdExtension;
            }

        }

    }

}
