using System;
using System.Text;

namespace Part3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите ключ доступа, если он у Вас имеется: ");
            string? key = Console.ReadLine();
            DocumentWorker documentWorker = VersionDecide(key);
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }

        public static DocumentWorker VersionDecide(string? key)
        {
            if (key == "pro")
            {
                Console.WriteLine("Используется версия Pro.");
                return new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                Console.WriteLine("Используется версия Expert.");
                return new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("Используется базовая версия.");
            }

            return new DocumentWorker();
        }
    }

    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro.");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine(
                "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert.");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате.");
        }
    }
}