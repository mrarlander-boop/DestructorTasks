using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace CollegeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("==========================================================");
                Console.WriteLine("       СБОРНИК ЗАДАНИЙ ПО C#: ДЕСТРУКТОРЫ И СБОРКА МУСОРА ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("Введите номер задания (1 - 40) для запуска.");
                Console.WriteLine("Введите 'all' для запуска всех заданий подряд.");
                Console.WriteLine("Введите '0' для выхода.");
                Console.Write("Ваш выбор: ");

                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input == "0") break;

                if (input.ToLower() == "all")
                {
                    RunAllTasks();
                    continue;
                }

                if (int.TryParse(input, out int taskNum) && taskNum >= 1 && taskNum <= 40)
                {
                    RunSingleTask(taskNum);
                }
                else
                {
                    Console.WriteLine("Неверный номер. Пожалуйста, введите число от 1 до 40.");
                }

                Console.WriteLine("\nНажмите Enter для продолжения...");
                Console.ReadLine();
            }
        }

        static void RunSingleTask(int number)
        {
            Console.WriteLine($"\n--- ЗАПУСК ЗАДАНИЯ {number} ---");
            switch (number)
            {
                case 1: Task01.Run(); break;
                case 2: Task02.Run(); break;
                case 3: Task03.Run(); break;
                case 4: Task04.Run(); break;
                case 5: Task05.Run(); break;
                case 6: Task06.Run(); break;
                case 7: Task07.Run(); break;
                case 8: Task08.Run(); break;
                case 9: Task09.Run(); break;
                case 10: Task10.Run(); break;
                case 11: Task11.Run(); break;
                case 12: Task12.Run(); break;
                case 13: Task13.Run(); break;
                case 14: Task14.Run(); break;
                case 15: Task15.Run(); break;
                case 16: Task16.Run(); break;
                case 17: Task17.Run(); break;
                case 18: Task18.Run(); break;
                case 19: Task19.Run(); break;
                case 20: Task20.Run(); break;
                case 21: Task21.Run(); break;
                case 22: Task22.Run(); break;
                case 23: Task23.Run(); break;
                case 24: Task24.Run(); break;
                case 25: Task25.Run(); break;
                case 26: Task26.Run(); break;
                case 27: Task27.Run(); break;
                case 28: Task28.Run(); break;
                case 29: Task29.Run(); break;
                case 30: Task30.Run(); break;
                case 31: Task31.Run(); break;
                case 32: Task32.Run(); break;
                case 33: Task33.Run(); break;
                case 34: Task34.Run(); break;
                case 35: Task35.Run(); break;
                case 36: Task36.Run(); break;
                case 37: Task37.Run(); break;
                case 38: Task38.Run(); break;
                case 39: Task39.Run(); break;
                case 40: Task40.Run(); break;
            }
        }

        static void RunAllTasks()
        {
            for (int i = 1; i <= 40; i++)
            {
                RunSingleTask(i);
            }
        }
    }

    #region Задание 1. Простой деструктор
    // Создайте класс Student с полем Name. Реализуйте деструктор, который выводит сообщение об удалении объекта.
    public class Task01
    {
        public class Student
        {
            public string Name;

            public Student(string name)
            {
                Name = name;
                Console.WriteLine($"Студент {Name} создан.");
            }

            ~Student()
            {
                Console.WriteLine($"[Деструктор] Студент {Name} удален из памяти.");
            }
        }

        public static void Run()
        {
            CreateStudent();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateStudent()
        {
            Student s = new Student("Иван Иванов");
        }
    }
    #endregion

    #region Задание 2. Деструктор автомобиля
    // Создайте класс Car с полями Brand и Year. Реализуйте деструктор с сообщением о завершении работы объекта.
    public class Task02
    {
        public class Car
        {
            public string Brand;
            public int Year;

            public Car(string brand, int year)
            {
                Brand = brand;
                Year = year;
                Console.WriteLine($"Автомобиль {Brand} ({Year}) создан.");
            }

            ~Car()
            {
                Console.WriteLine($"[Деструктор] Автомобиль {Brand} ({Year}) завершил работу и удален.");
            }
        }

        public static void Run()
        {
            CreateCar();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateCar()
        {
            Car car = new Car("Toyota Camry", 2022);
        }
    }
    #endregion

    #region Задание 3. Деструктор книги
    // Создайте класс Book с полями Title и Author. При уничтожении объекта деструктор должен выводить название книги.
    public class Task03
    {
        public class Book
        {
            public string Title;
            public string Author;

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
                Console.WriteLine($"Книга \"{Title}\" (автор: {Author}) создана.");
            }

            ~Book()
            {
                Console.WriteLine($"[Деструктор] Уничтожен объект книги: \"{Title}\".");
            }
        }

        public static void Run()
        {
            CreateBook();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateBook()
        {
            Book b = new Book("Война и мир", "Лев Толстой");
        }
    }
    #endregion

    #region Задание 4. Деструктор компьютера
    // Создайте класс Computer с полем Model. Реализуйте деструктор, который сообщает об освобождении объекта.
    public class Task04
    {
        public class Computer
        {
            public string Model;

            public Computer(string model)
            {
                Model = model;
                Console.WriteLine($"Компьютер {Model} собран и работает.");
            }

            ~Computer()
            {
                Console.WriteLine($"[Деструктор] Компьютер {Model}: память освобождена.");
            }
        }

        public static void Run()
        {
            CreateComputer();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateComputer()
        {
            Computer pc = new Computer("Asus ROG Strix");
        }
    }
    #endregion

    #region Задание 5. Деструктор телефона
    // Создайте класс Phone с полями Brand и Model. Добавьте деструктор с соответствующим сообщением.
    public class Task05
    {
        public class Phone
        {
            public string Brand;
            public string Model;

            public Phone(string brand, string model)
            {
                Brand = brand;
                Model = model;
                Console.WriteLine($"Телефон {Brand} {Model} создан.");
            }

            ~Phone()
            {
                Console.WriteLine($"[Деструктор] Телефон {Brand} {Model} удален из памяти.");
            }
        }

        public static void Run()
        {
            CreatePhone();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreatePhone()
        {
            Phone p = new Phone("Apple", "iPhone 15");
        }
    }
    #endregion

    #region Задание 6. Несколько объектов
    // Создайте 5 объектов класса Student. Реализуйте деструктор и понаблюдайте за сообщениями при сборке мусора.
    public class Task06
    {
        public class Student
        {
            public string Name;

            public Student(string name)
            {
                Name = name;
                Console.WriteLine($"Создан {Name}");
            }

            ~Student()
            {
                Console.WriteLine($"[Деструктор] {Name} удален сборщиком мусора.");
            }
        }

        public static void Run()
        {
            CreateStudents();
            Console.WriteLine("Запуск GC.Collect() для 5 студентов...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateStudents()
        {
            for (int i = 1; i <= 5; i++)
            {
                Student s = new Student($"Студент №{i}");
            }
        }
    }
    #endregion

    #region Задание 7. Метод создания объектов
    // Создайте класс Product и метод CreateProduct(), возвращающий новый объект. Реализуйте деструктор.
    public class Task07
    {
        public class Product
        {
            public string Name;

            public Product(string name)
            {
                Name = name;
                Console.WriteLine($"Создан товар: {Name}");
            }

            ~Product()
            {
                Console.WriteLine($"[Деструктор] Товар '{Name}' удален.");
            }
        }

        public static Product CreateProduct(string name)
        {
            return new Product(name);
        }

        public static void Run()
        {
            TestCreation();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void TestCreation()
        {
            Product p = CreateProduct("Ноутбук MSI");
            // Метод завершается, ссылка теряется
        }
    }
    #endregion

    #region Задание 8. Объект внутри метода
    // Создайте объект класса TestObject внутри отдельного метода. После завершения метода вызовите сборщик мусора и проверьте работу деструктора.
    public class Task08
    {
        public class TestObject
        {
            public string Title;

            public TestObject(string title)
            {
                Title = title;
                Console.WriteLine($"Объект '{Title}' инициализирован.");
            }

            ~TestObject()
            {
                Console.WriteLine($"[Деструктор] Объект '{Title}' уничтожен после выхода из метода.");
            }
        }

        private static void InnerMethod()
        {
            TestObject obj = new TestObject("Временный локальный объект");
            Console.WriteLine("Выполнение кода внутри InnerMethod...");
        }

        public static void Run()
        {
            Console.WriteLine("Вызов InnerMethod()...");
            InnerMethod();
            Console.WriteLine("InnerMethod() завершился. Запуск сборщика мусора...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
    #endregion

    #region Задание 9. Деструктор с идентификатором
    // Создайте класс Employee с полем Id. Деструктор должен выводить ID уничтоженного объекта.
    public class Task09
    {
        public class Employee
        {
            public int Id;

            public Employee(int id)
            {
                Id = id;
                Console.WriteLine($"Сотрудник #{Id} добавлен в штат.");
            }

            ~Employee()
            {
                Console.WriteLine($"[Деструктор] Сотрудник с ID: {Id} уничтожен.");
            }
        }

        public static void Run()
        {
            CreateEmployees();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateEmployees()
        {
            Employee e1 = new Employee(101);
            Employee e2 = new Employee(102);
        }
    }
    #endregion

    #region Задание 10. Количество объектов
    // Создайте класс Counter, который увеличивает статическую переменную при создании объекта. В деструкторе уменьшайте её значение.
    public class Task10
    {
        public class Counter
        {
            public static int ObjectCount = 0;

            public Counter()
            {
                ObjectCount++;
                Console.WriteLine($"Объект Counter создан. Всего живых объектов: {ObjectCount}");
            }

            ~Counter()
            {
                ObjectCount--;
                Console.WriteLine($"[Деструктор] Объект Counter удален. Осталось живых объектов: {ObjectCount}");
            }
        }

        public static void Run()
        {
            Console.WriteLine($"Начальное количество объектов: {Counter.ObjectCount}");
            CreateBatch();
            Console.WriteLine($"После создания объектов в методе: {Counter.ObjectCount}");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine($"После работы сборщика мусора: {Counter.ObjectCount}");
        }

        private static void CreateBatch()
        {
            for (int i = 0; i < 3; i++)
            {
                Counter c = new Counter();
            }
        }
    }
    #endregion

    #region Задание 11. Управление ресурсом
    // Создайте класс FileManager, который имитирует работу с файлом. Реализуйте деструктор, выводящий сообщение об освобождении ресурса.
    public class Task11
    {
        public class FileManager
        {
            public string FileName;
            public bool IsOpen;

            public FileManager(string fileName)
            {
                FileName = fileName;
                IsOpen = true;
                Console.WriteLine($"Файл '{FileName}' успешно открыт.");
            }

            public void Close()
            {
                if (IsOpen)
                {
                    IsOpen = false;
                    Console.WriteLine($"Файл '{FileName}' закрыт пользователем.");
                }
            }

            ~FileManager()
            {
                if (IsOpen)
                {
                    IsOpen = false;
                    Console.WriteLine($"[Деструктор] Ресурс файла '{FileName}' автоматически освобожден деструктором.");
                }
            }
        }

        public static void Run()
        {
            OpenFileWithoutClose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void OpenFileWithoutClose()
        {
            FileManager fm = new FileManager("data.txt");
            // Забыли вызвать fm.Close()
        }
    }
    #endregion

    #region Задание 12. Деструктор и метод
    // Создайте класс Printer с методом Print(). В деструкторе выведите сообщение «Принтер удалён».
    public class Task12
    {
        public class Printer
        {
            public void Print(string text)
            {
                Console.WriteLine($"Печать документа: {text}");
            }

            ~Printer()
            {
                Console.WriteLine("[Деструктор] Принтер удалён.");
            }
        }

        public static void Run()
        {
            UsePrinter();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void UsePrinter()
        {
            Printer printer = new Printer();
            printer.Print("Отчет за 1-й семестр");
        }
    }
    #endregion

    #region Задание 13. Массив объектов
    // Создайте массив из 10 объектов класса Device. Реализуйте деструктор и проверьте его работу после очистки массива.
    public class Task13
    {
        public class Device
        {
            public int Id;

            public Device(int id)
            {
                Id = id;
            }

            ~Device()
            {
                Console.WriteLine($"[Деструктор] Устройство #{Id} удалено.");
            }
        }

        public static void Run()
        {
            FillAndClearArray();
            Console.WriteLine("Массив очищен. Вызываем GC.Collect()...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void FillAndClearArray()
        {
            Device[] devices = new Device[10];
            for (int i = 0; i < devices.Length; i++)
            {
                devices[i] = new Device(i + 1);
            }
            Console.WriteLine($"Создан массив из {devices.Length} устройств.");

            // Очищаем массив
            for (int i = 0; i < devices.Length; i++)
            {
                devices[i] = null;
            }
        }
    }
    #endregion

    #region Задание 14. Циклическое создание объектов
    // В цикле создайте 20 объектов класса Person. После завершения цикла запустите GC.Collect().
    public class Task14
    {
        public class Person
        {
            public int Number;

            public Person(int number)
            {
                Number = number;
            }

            ~Person()
            {
                Console.WriteLine($"[Деструктор] Персона #{Number} собрана мусорщиком.");
            }
        }

        public static void Run()
        {
            CreateManyPersons();
            Console.WriteLine("Цикл завершен. Вызов сборщика мусора...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateManyPersons()
        {
            for (int i = 1; i <= 20; i++)
            {
                Person p = new Person(i);
            }
        }
    }
    #endregion

    #region Задание 15. Деструктор с несколькими полями
    // Создайте класс BankAccount с полями Number, Owner, Balance. Деструктор должен выводить номер счёта.
    public class Task15
    {
        public class BankAccount
        {
            public string Number;
            public string Owner;
            public decimal Balance;

            public BankAccount(string number, string owner, decimal balance)
            {
                Number = number;
                Owner = owner;
                Balance = balance;
                Console.WriteLine($"Счёт {Number} открыт для {Owner} с балансом {Balance} руб.");
            }

            ~BankAccount()
            {
                Console.WriteLine($"[Деструктор] Банковский счёт {Number} удален из системы.");
            }
        }

        public static void Run()
        {
            CreateAccount();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateAccount()
        {
            BankAccount acc = new BankAccount("RU123456789", "Сидоров Пётр", 54000.50m);
        }
    }
    #endregion

    #region Задание 16. Журнал объектов
    // Создайте класс LogObject. При уничтожении объекта записывайте сообщение в консоль о его удалении.
    public class Task16
    {
        public class LogObject
        {
            public string Name;

            public LogObject(string name)
            {
                Name = name;
                Console.WriteLine($"[Журнал: Старт] Объект '{Name}' создан.");
            }

            ~LogObject()
            {
                Console.WriteLine($"[Журнал: Удаление] Объект '{Name}' уничтожен сборщиком мусора в {DateTime.Now:HH:mm:ss}.");
            }
        }

        public static void Run()
        {
            CreateLogObjects();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateLogObjects()
        {
            LogObject obj = new LogObject("ЗаписьВЖурнале_01");
        }
    }
    #endregion

    #region Задание 17. Сравнение объектов
    // Создайте класс Animal с полем Name. Создайте несколько объектов и исследуйте порядок вызова деструкторов.
    public class Task17
    {
        public class Animal
        {
            public string Name;

            public Animal(string name)
            {
                Name = name;
                Console.WriteLine($"Животное '{Name}' появилось.");
            }

            ~Animal()
            {
                Console.WriteLine($"[Деструктор] Животное '{Name}' финализировано.");
            }
        }

        public static void Run()
        {
            CreateAnimals();
            Console.WriteLine("Сборка мусора: наблюдаем за порядком финализации...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateAnimals()
        {
            Animal a1 = new Animal("Кот");
            Animal a2 = new Animal("Собака");
            Animal a3 = new Animal("Хомяк");
        }
    }
    #endregion

    #region Задание 18. Большое количество объектов
    // Создайте 100 объектов класса DataObject. Принудительно запустите сборку мусора и проанализируйте результат.
    public class Task18
    {
        public class DataObject
        {
            public int Id;
            public static int CollectedCount = 0;

            public DataObject(int id)
            {
                Id = id;
            }

            ~DataObject()
            {
                CollectedCount++;
            }
        }

        public static void Run()
        {
            DataObject.CollectedCount = 0;
            CreateHundred();
            Console.WriteLine("100 объектов создано. Вызываем GC.Collect()...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine($"Итог: уничтожено {DataObject.CollectedCount} из 100 объектов.");
        }

        private static void CreateHundred()
        {
            for (int i = 1; i <= 100; i++)
            {
                DataObject obj = new DataObject(i);
            }
        }
    }
    #endregion

    #region Задание 19. Деструктор и GC.Collect()
    // Создайте класс Test. Создайте и уничтожьте несколько объектов, используя GC.Collect() и GC.WaitForPendingFinalizers().
    public class Task19
    {
        public class Test
        {
            public int Number;

            public Test(int number)
            {
                Number = number;
                Console.WriteLine($"Test #{Number} создан.");
            }

            ~Test()
            {
                Console.WriteLine($"[Деструктор] Test #{Number} уничтожен.");
            }
        }

        public static void Run()
        {
            MakeTests();
            Console.WriteLine("Запуск GC.Collect()...");
            GC.Collect();
            Console.WriteLine("Ожидание потока финализации через GC.WaitForPendingFinalizers()...");
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Все деструкторы гарантированно завершили работу.");
        }

        private static void MakeTests()
        {
            for (int i = 1; i <= 3; i++)
            {
                Test t = new Test(i);
            }
        }
    }
    #endregion

    #region Задание 20. Определение момента очистки
    // Создайте класс ObjectTracker. Реализуйте деструктор и проведите эксперимент, определяя, когда он вызывается.
    public class Task20
    {
        public class ObjectTracker
        {
            public string Name;

            public ObjectTracker(string name)
            {
                Name = name;
                Console.WriteLine($"Трекер: объект '{Name}' создан.");
            }

            ~ObjectTracker()
            {
                Console.WriteLine($"[Деструктор] Трекер: объект '{Name}' уничтожен сборщиком мусора!");
            }
        }

        public static void Run()
        {
            CreateAndLoseReference();
            Console.WriteLine("1. Ссылка потеряна, но деструктор еще не сработал автоматически.");
            Console.WriteLine("2. Выполняем полезную работу в программе...");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"   ...шаг {i + 1}...");
            }

            Console.WriteLine("3. Теперь вызываем GC.Collect():");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("4. Эксперимент завершен.");
        }

        private static void CreateAndLoseReference()
        {
            ObjectTracker tracker = new ObjectTracker("ЭкспериментальныйОбъект");
        }
    }
    #endregion

    #region Задание 21. Деструктор и GC.SuppressFinalize()
    // Создайте класс с деструктором и методом Dispose(). Изучите, как GC.SuppressFinalize() влияет на вызов деструктора.
    public class Task21
    {
        public class DisposableItem : IDisposable
        {
            public string Name;

            public DisposableItem(string name)
            {
                Name = name;
                Console.WriteLine($"Создан {Name}.");
            }

            public void Dispose()
            {
                Console.WriteLine($"Вызван Dispose() для {Name}. Вызываем GC.SuppressFinalize(this).");
                GC.SuppressFinalize(this); // Отменяем вызов финализатора
            }

            ~DisposableItem()
            {
                Console.WriteLine($"[Деструктор] Сработал деструктор для {Name} (Dispose не был вызван!).");
            }
        }

        public static void Run()
        {
            Experiment();
            Console.WriteLine("Вызываем GC.Collect()...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void Experiment()
        {
            DisposableItem item1 = new DisposableItem("Объект-1 (с Dispose)");
            item1.Dispose(); // Деструктор для него не вызовется

            DisposableItem item2 = new DisposableItem("Объект-2 (без Dispose)");
            // Dispose не вызываем, деструктор сработает
        }
    }
    #endregion

    #region Задание 22. Реализация IDisposable
    // Создайте класс ResourceManager, реализующий IDisposable. Добавьте деструктор и метод Dispose().
    public class Task22
    {
        public class ResourceManager : IDisposable
        {
            public string ResourceName;
            public bool IsDisposed = false;

            public ResourceManager(string name)
            {
                ResourceName = name;
                Console.WriteLine($"Ресурс '{ResourceName}' захвачен.");
            }

            public void Dispose()
            {
                if (!IsDisposed)
                {
                    IsDisposed = true;
                    Console.WriteLine($"Ресурс '{ResourceName}' корректно освобожден через Dispose().");
                    GC.SuppressFinalize(this);
                }
            }

            ~ResourceManager()
            {
                if (!IsDisposed)
                {
                    Console.WriteLine($"[Деструктор] Ресурс '{ResourceName}' освобожден в деструкторе (забыли Dispose).");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("Тест 1: ручной вызов Dispose():");
            ResourceManager res1 = new ResourceManager("ГрафическийКонтекст_A");
            res1.Dispose();

            Console.WriteLine("\nТест 2: забытый Dispose() (сработает деструктор):");
            CreateForgottenResource();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateForgottenResource()
        {
            ResourceManager res2 = new ResourceManager("ГрафическийКонтекст_B");
        }
    }
    #endregion

    #region Задание 23. Паттерн Dispose
    // Реализуйте класс DatabaseConnection, использующий стандартный шаблон Dispose(bool disposing) и деструктор.
    public class Task23
    {
        public class DatabaseConnection : IDisposable
        {
            private bool _disposed = false;
            public string ConnectionString;

            public DatabaseConnection(string connString)
            {
                ConnectionString = connString;
                Console.WriteLine($"Подключение к БД открыто: {ConnectionString}");
            }

            // Публичный метод IDisposable
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            // Защищенный виртуальный метод с флагом disposing
            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("Освобождение управляемых ресурсов соединения...");
                    }

                    Console.WriteLine("Освобождение неуправляемых ресурсов (низкоуровневый сокет)...");
                    _disposed = true;
                }
            }

            // Деструктор вызывает Dispose(false)
            ~DatabaseConnection()
            {
                Console.WriteLine("[Деструктор] DatabaseConnection финализируется.");
                Dispose(false);
            }
        }

        public static void Run()
        {
            Console.WriteLine("1. Освобождение через Dispose():");
            using (DatabaseConnection db = new DatabaseConnection("Server=myServer;Database=ShopDB;"))
            {
                Console.WriteLine("Работа с базой данных внутри using...");
            }
        }
    }
    #endregion

    #region Задание 24. Освобождение ресурсов
    // Создайте класс FileResource, который имитирует открытие файла. Реализуйте IDisposable и деструктор.
    public class Task24
    {
        public class FileResource : IDisposable
        {
            private bool _disposed = false;
            public string FileName;

            public FileResource(string fileName)
            {
                FileName = fileName;
                Console.WriteLine($"Файловый ресурс '{FileName}' открыт.");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine($"Файл '{FileName}' штатно закрыт через Dispose().");
                    }
                    else
                    {
                        Console.WriteLine($"[Деструктор] Файл '{FileName}' закрыт в процессе сборки мусора.");
                    }
                    _disposed = true;
                }
            }

            ~FileResource()
            {
                Dispose(false);
            }
        }

        public static void Run()
        {
            using (FileResource f = new FileResource("document.pdf"))
            {
                Console.WriteLine("Чтение страниц документа...");
            }
        }
    }
    #endregion

    #region Задание 25. Деструктор и наследование
    // Создайте базовый класс Device и производный класс Computer. Реализуйте деструкторы в обоих классах.
    public class Task25
    {
        public class Device
        {
            public Device()
            {
                Console.WriteLine("Конструктор Device");
            }

            ~Device()
            {
                Console.WriteLine("[Деструктор] Базовый класс Device уничтожен.");
            }
        }

        public class Computer : Device
        {
            public Computer()
            {
                Console.WriteLine("Конструктор Computer");
            }

            ~Computer()
            {
                Console.WriteLine("[Деструктор] Дочерний класс Computer уничтожен.");
            }
        }

        public static void Run()
        {
            CreateHierarchy();
            Console.WriteLine("Вызываем GC.Collect() для проверки порядка финализации...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateHierarchy()
        {
            Computer pc = new Computer();
        }
    }
    #endregion

    #region Задание 26. Порядок деструкторов
    // Создайте цепочку наследования Animal → Mammal → Dog. Добавьте деструктор в каждый класс и определите порядок их выполнения.
    public class Task26
    {
        public class Animal
        {
            ~Animal()
            {
                Console.WriteLine("[Деструктор 3] Базовый класс Animal уничтожен.");
            }
        }

        public class Mammal : Animal
        {
            ~Mammal()
            {
                Console.WriteLine("[Деструктор 2] Промежуточный класс Mammal уничтожен.");
            }
        }

        public class Dog : Mammal
        {
            ~Dog()
            {
                Console.WriteLine("[Деструктор 1] Самый нижний дочерний класс Dog уничтожен.");
            }
        }

        public static void Run()
        {
            CreateDog();
            Console.WriteLine("Запуск GC. Деструкторы вызываются снизу вверх по иерархии:");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void CreateDog()
        {
            Dog dog = new Dog();
        }
    }
    #endregion

    #region Задание 27. Несколько ресурсов
    // Создайте класс ResourceHolder, содержащий несколько условных ресурсов. Реализуйте их освобождение через Dispose() и деструктор.
    public class Task27
    {
        public class ResourceHolder : IDisposable
        {
            private bool _disposed = false;
            public string ManagedBuffer;
            public string NativeHandle;

            public ResourceHolder()
            {
                ManagedBuffer = "Управляемый буфер данных (1024 байта)";
                NativeHandle = "Неуправляемый дескриптор окна #0045";
                Console.WriteLine("Ресурсы успешно выделены.");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine($"Освобождение: {ManagedBuffer}");
                        ManagedBuffer = null;
                    }

                    Console.WriteLine($"Освобождение: {NativeHandle}");
                    NativeHandle = null;

                    _disposed = true;
                }
            }

            ~ResourceHolder()
            {
                Console.WriteLine("[Деструктор] ResourceHolder сработал.");
                Dispose(false);
            }
        }

        public static void Run()
        {
            using (ResourceHolder holder = new ResourceHolder())
            {
                Console.WriteLine("Использование обоих ресурсов...");
            }
        }
    }
    #endregion

    #region Задание 28. Защита от повторного освобождения
    // Реализуйте класс Resource с флагом _disposed. Метод Dispose() не должен освобождать ресурс повторно.
    public class Task28
    {
        public class SafeResource : IDisposable
        {
            private bool _disposed = false;

            public void Dispose()
            {
                if (_disposed)
                {
                    Console.WriteLine("Предотвращение: ресурс уже был освобожден ранее, повторный вызов проигнорирован.");
                    return;
                }

                Console.WriteLine("Первый вызов Dispose(): ресурсы успешно освобождены!");
                _disposed = true;
                GC.SuppressFinalize(this);
            }

            ~SafeResource()
            {
                Dispose();
            }
        }

        public static void Run()
        {
            SafeResource res = new SafeResource();
            Console.WriteLine("Вызываем Dispose() первый раз:");
            res.Dispose();

            Console.WriteLine("Вызываем Dispose() второй раз:");
            res.Dispose();
        }
    }
    #endregion

    #region Задание 29. Деструктор и исключения
    // Создайте класс, работающий с условным ресурсом. Исследуйте поведение программы при возникновении исключения до вызова Dispose().
    public class Task29
    {
        public class DangerousTaskResource : IDisposable
        {
            private bool _disposed = false;

            public DangerousTaskResource()
            {
                Console.WriteLine("Опасный ресурс открыт.");
            }

            public void DoSomethingRisky()
            {
                Console.WriteLine("Происходит критическая ошибка...");
                throw new InvalidOperationException("Аварийное завершение операции!");
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    Console.WriteLine("Dispose() гарантированно вызван!");
                    _disposed = true;
                    GC.SuppressFinalize(this);
                }
            }

            ~DangerousTaskResource()
            {
                if (!_disposed)
                {
                    Console.WriteLine("[Деструктор] Ресурс спасен финализатором после сбоя.");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("Вариант: использование using гарантирует Dispose даже при исключении:");
            try
            {
                using (DangerousTaskResource res = new DangerousTaskResource())
                {
                    res.DoSomethingRisky();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Перехвачено исключение: {ex.Message}");
            }
        }
    }
    #endregion

    #region Задание 30. Деструктор и using
    // Создайте класс MyResource, реализующий IDisposable. Используйте его через конструкцию using и определите, вызывается ли деструктор.
    public class Task30
    {
        public class MyResource : IDisposable
        {
            private bool _disposed = false;

            public MyResource()
            {
                Console.WriteLine("MyResource создан.");
            }

            public void Work()
            {
                Console.WriteLine("MyResource выполняет операцию.");
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    Console.WriteLine("Dispose() выполнен. Вызываем GC.SuppressFinalize().");
                    _disposed = true;
                    GC.SuppressFinalize(this);
                }
            }

            ~MyResource()
            {
                Console.WriteLine("[Деструктор] Этот текст появится только если Dispose НЕ вызвался.");
            }
        }

        public static void Run()
        {
            using (var res = new MyResource())
            {
                res.Work();
            }

            Console.WriteLine("Блок using завершен. Проверяем вызов деструктора сборщиком мусора...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Деструктор не сработал, так как GC.SuppressFinalize предотвратил его вызов!");
        }
    }
    #endregion

    #region Задание 31. Собственный менеджер ресурсов
    // Создайте класс ResourceManager, который хранит список созданных ресурсов. Реализуйте IDisposable и финализатор.
    public class Task31
    {
        public class SingleResource : IDisposable
        {
            public string Title;

            public SingleResource(string title)
            {
                Title = title;
            }

            public void Dispose()
            {
                Console.WriteLine($"  Ресурс '{Title}' освобожден.");
            }
        }

        public class MyCustomManager : IDisposable
        {
            private bool _disposed = false;
            private List<SingleResource> _resources = new List<SingleResource>();

            public void AddResource(SingleResource r)
            {
                _resources.Add(r);
                Console.WriteLine($"В менеджер добавлен: {r.Title}");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("Менеджер освобождает все зарегистрированные ресурсы:");
                        foreach (var item in _resources)
                        {
                            item.Dispose();
                        }
                        _resources.Clear();
                    }
                    _disposed = true;
                }
            }

            ~MyCustomManager()
            {
                Console.WriteLine("[Деструктор] Менеджер ресурсов финализируется.");
                Dispose(false);
            }
        }

        public static void Run()
        {
            using (MyCustomManager manager = new MyCustomManager())
            {
                manager.AddResource(new SingleResource("Аудиопоток"));
                manager.AddResource(new SingleResource("Видеопоток"));
            }
        }
    }
    #endregion

    #region Задание 32. Работа с файловым потоком
    // Создайте класс FileHandler, который открывает FileStream. Реализуйте корректное освобождение ресурса через Dispose() и деструктор.
    public class Task32
    {
        public class FileHandler : IDisposable
        {
            private bool _disposed = false;
            private FileStream _fileStream;
            public string FilePath;

            public FileHandler(string path)
            {
                FilePath = path;
                // Создаем временный файл и открываем поток
                _fileStream = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Console.WriteLine($"Файловый поток для '{FilePath}' открыт.");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        if (_fileStream != null)
                        {
                            _fileStream.Close();
                            _fileStream.Dispose();
                            _fileStream = null;
                            Console.WriteLine("FileStream закрыт и освобожден через Dispose().");
                        }
                    }
                    else
                    {
                        Console.WriteLine("[Деструктор] FileStream закрыт в деструкторе.");
                    }
                    _disposed = true;
                }
            }

            ~FileHandler()
            {
                Dispose(false);
            }
        }

        public static void Run()
        {
            string tempFile = "temp_test_file.txt";
            using (FileHandler handler = new FileHandler(tempFile))
            {
                Console.WriteLine("Запись данных в поток...");
            }

            // Удаляем временный файл
            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
                Console.WriteLine("Временный файл удален.");
            }
        }
    }
    #endregion

    #region Задание 33. Работа с подключением к БД
    // Создайте класс DatabaseManager, имитирующий подключение к базе данных. Реализуйте IDisposable, Dispose(bool) и деструктор.
    public class Task33
    {
        public class DatabaseManager : IDisposable
        {
            private bool _disposed = false;
            public string DbName;
            public bool IsConnected;

            public DatabaseManager(string dbName)
            {
                DbName = dbName;
                IsConnected = true;
                Console.WriteLine($"Подключение к базе '{DbName}' установлено.");
            }

            public void ExecuteQuery(string query)
            {
                if (_disposed)
                {
                    Console.WriteLine("Ошибка: подключение уже закрыто!");
                    return;
                }
                Console.WriteLine($"Выполнен SQL-запрос '{query}' к базе '{DbName}'.");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("Очистка управляемых пулов соединений...");
                    }
                    Console.WriteLine($"Физическое соединение с базой '{DbName}' разорвано.");
                    IsConnected = false;
                    _disposed = true;
                }
            }

            ~DatabaseManager()
            {
                Console.WriteLine("[Деструктор] Соединение с БД финализировано сборщиком мусора.");
                Dispose(false);
            }
        }

        public static void Run()
        {
            using (DatabaseManager db = new DatabaseManager("StudentsDB"))
            {
                db.ExecuteQuery("SELECT * FROM Students");
            }
        }
    }
    #endregion

    #region Задание 34. Иерархия ресурсов
    // Создайте классы Resource → FileResource → NetworkResource. В каждом классе реализуйте корректное освобождение ресурсов.
    public class Task34
    {
        public class Resource : IDisposable
        {
            private bool _disposed = false;

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("1. Resource: базовые ресурсы освобождены.");
                    }
                    _disposed = true;
                }
            }

            ~Resource()
            {
                Dispose(false);
            }
        }

        public class FileResource : Resource
        {
            private bool _fileDisposed = false;

            protected override void Dispose(bool disposing)
            {
                if (!_fileDisposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("2. FileResource: файловые дескрипторы закрыты.");
                    }
                    _fileDisposed = true;
                }
                base.Dispose(disposing);
            }
        }

        public class NetworkResource : FileResource
        {
            private bool _netDisposed = false;

            protected override void Dispose(bool disposing)
            {
                if (!_netDisposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("3. NetworkResource: сетевые подключения разорваны.");
                    }
                    _netDisposed = true;
                }
                base.Dispose(disposing);
            }
        }

        public static void Run()
        {
            Console.WriteLine("Создание объекта NetworkResource в блоке using:");
            using (NetworkResource net = new NetworkResource())
            {
                Console.WriteLine("Сетевой файловый ресурс используется...");
            }
        }
    }
    #endregion

    #region Задание 35. Деструктор и сборка мусора
    // Создайте программу, которая создаёт большое количество объектов с деструкторами. Сравните работу программы с объектами, имеющими деструктор, и без него.
    public class Task35
    {
        public class ObjectWithoutFinalizer
        {
            public int Value;
            public ObjectWithoutFinalizer(int v) { Value = v; }
        }

        public class ObjectWithFinalizer
        {
            public int Value;
            public ObjectWithFinalizer(int v) { Value = v; }
            ~ObjectWithFinalizer()
            {
                // Наличие деструктора увеличивает накладные расходы на GC
            }
        }

        public static void Run()
        {
            Console.WriteLine("1. Создание 50 000 объектов БЕЗ финализатора...");
            CreateWithoutFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("   Сборка мусора без финализаторов завершена мгновенно.");

            Console.WriteLine("2. Создание 50 000 объектов С финализатором...");
            CreateWithFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("   Сборка мусора с финализаторами потребовала постановки в очередь финализации.");
        }

        private static void CreateWithoutFinalizers()
        {
            for (int i = 0; i < 50000; i++)
            {
                var item = new ObjectWithoutFinalizer(i);
            }
        }

        private static void CreateWithFinalizers()
        {
            for (int i = 0; i < 50000; i++)
            {
                var item = new ObjectWithFinalizer(i);
            }
        }
    }
    #endregion

    #region Задание 36. Анализ производительности
    // Создайте 10 000 объектов с финализаторами и 10 000 объектов без финализаторов. С помощью Stopwatch сравните производительность сборки мусора.
    public class Task36
    {
        public class PlainObject
        {
            public int Id;
            public PlainObject(int id) { Id = id; }
        }

        public class FinalizableObject
        {
            public int Id;
            public FinalizableObject(int id) { Id = id; }
            ~FinalizableObject()
            {
                // Финализатор
            }
        }

        public static void Run()
        {
            int count = 10000;
            Console.WriteLine($"Тест производительности для {count} объектов.");

            // Тест 1: Без финализаторов
            CreatePlainObjects(count);
            Stopwatch sw = Stopwatch.StartNew();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            sw.Stop();
            long timePlain = sw.ElapsedMilliseconds;
            Console.WriteLine($"Время сборки мусора БЕЗ финализаторов: {timePlain} мс");

            // Тест 2: С финализаторами
            CreateFinalizableObjects(count);
            sw.Restart();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            sw.Stop();
            long timeFinalizable = sw.ElapsedMilliseconds;
            Console.WriteLine($"Время сборки мусора С финализаторами: {timeFinalizable} мс");
        }

        private static void CreatePlainObjects(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var obj = new PlainObject(i);
            }
        }

        private static void CreateFinalizableObjects(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var obj = new FinalizableObject(i);
            }
        }
    }
    #endregion

    #region Задание 37. Имитация системного ресурса
    // Создайте класс SystemResource, который имитирует системный ресурс через IntPtr. Реализуйте безопасное освобождение ресурса.
    public class Task37
    {
        public class SystemResource : IDisposable
        {
            private IntPtr _handle;
            private bool _disposed = false;

            public SystemResource()
            {
                // Имитация выделения неуправляемого системного указателя
                _handle = new IntPtr(0xABCD);
                Console.WriteLine($"Системный ресурс выделен. Указатель handle: 0x{_handle.ToInt64():X}");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("Освобождение управляемых компонентов...");
                    }

                    // Освобождение неуправляемого IntPtr
                    if (_handle != IntPtr.Zero)
                    {
                        Console.WriteLine($"Неуправляемый ресурс 0x{_handle.ToInt64():X} освобожден!");
                        _handle = IntPtr.Zero;
                    }

                    _disposed = true;
                }
            }

            ~SystemResource()
            {
                Console.WriteLine("[Деструктор] Системный ресурс освобожден финализатором.");
                Dispose(false);
            }
        }

        public static void Run()
        {
            using (SystemResource sys = new SystemResource())
            {
                Console.WriteLine("Работа с системным ресурсом...");
            }
        }
    }
    #endregion

    #region Задание 38. SafeHandle
    // Создайте класс, использующий SafeHandle для имитации работы с системным ресурсом. Сравните его с обычным деструктором.
    public class Task38
    {
        // Безопасная системная обертка над дескриптором
        public class SimpleSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public SimpleSafeHandle() : base(true)
            {
                SetHandle(new IntPtr(0x7777));
                Console.WriteLine("SimpleSafeHandle: дескриптор 0x7777 безопасно выделен.");
            }

            protected override bool ReleaseHandle()
            {
                Console.WriteLine("SimpleSafeHandle: дескриптор 0x7777 гарантированно освобожден.");
                return true;
            }
        }

        public class SafeResourceManager : IDisposable
        {
            private SimpleSafeHandle _handle;
            private bool _disposed = false;

            public SafeResourceManager()
            {
                _handle = new SimpleSafeHandle();
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    if (_handle != null && !_handle.IsInvalid)
                    {
                        _handle.Dispose();
                    }
                    _disposed = true;
                }
            }
            // Заметьте: деструктор не нужен, SafeHandle финализирует себя сам!
        }

        public static void Run()
        {
            using (SafeResourceManager res = new SafeResourceManager())
            {
                Console.WriteLine("Работаем через безопасный SafeHandle...");
            }
        }
    }
    #endregion

    #region Задание 39. Полный шаблон освобождения ресурсов
    // Реализуйте класс AdvancedResource, содержащий управляемый и неуправляемый ресурс. Используйте IDisposable, Dispose(bool), финализатор и GC.SuppressFinalize().
    public class Task39
    {
        public class AdvancedResource : IDisposable
        {
            private bool _disposed = false;
            private MemoryStream _managedStream; // Управляемый ресурс
            private IntPtr _unmanagedHandle;     // Неуправляемый ресурс

            public AdvancedResource()
            {
                _managedStream = new MemoryStream();
                _unmanagedHandle = new IntPtr(0x9999);
                Console.WriteLine("AdvancedResource: создан управляемый поток и неуправляемый указатель 0x9999.");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        // 1. Управляемые ресурсы
                        if (_managedStream != null)
                        {
                            _managedStream.Dispose();
                            _managedStream = null;
                            Console.WriteLine("1. Управляемый MemoryStream освобожден.");
                        }
                    }

                    // 2. Неуправляемые ресурсы (освобождаются всегда)
                    if (_unmanagedHandle != IntPtr.Zero)
                    {
                        Console.WriteLine($"2. Неуправляемый дескриптор 0x{_unmanagedHandle.ToInt64():X} освобожден.");
                        _unmanagedHandle = IntPtr.Zero;
                    }

                    _disposed = true;
                }
            }

            ~AdvancedResource()
            {
                Console.WriteLine("[Финализатор] AdvancedResource финализируется сборщиком мусора.");
                Dispose(false);
            }
        }

        public static void Run()
        {
            Console.WriteLine("Проверка полного паттерна Dispose:");
            using (AdvancedResource adv = new AdvancedResource())
            {
                Console.WriteLine("Использование ресурсов...");
            }
        }
    }
    #endregion

    #region Задание 40. Итоговый проект — менеджер ресурсов
    // Создайте приложение «Менеджер системных ресурсов». Программа должна: 
    // создавать несколько типов ресурсов; отслеживать созданные объекты; реализовывать IDisposable;
    // использовать деструктор; использовать GC.Collect(); использовать GC.WaitForPendingFinalizers();
    // предотвращать повторное освобождение ресурсов; выводить в консоль информацию о создании и освобождении каждого ресурса.
    public class Task40
    {
        public interface ISystemResource : IDisposable
        {
            string Name { get; }
            bool IsDisposed { get; }
        }

        // Тип ресурса 1: Текстовый файл
        public class TextFileResource : ISystemResource
        {
            public string Name { get; private set; }
            public bool IsDisposed { get; private set; }

            public TextFileResource(string name)
            {
                Name = name;
                IsDisposed = false;
                Console.WriteLine($"[+] Создан ресурс файла: {Name}");
            }

            public void Dispose()
            {
                if (IsDisposed) return;
                Console.WriteLine($"[-] Ресурс файла '{Name}' успешно закрыт.");
                IsDisposed = true;
                GC.SuppressFinalize(this);
            }

            ~TextFileResource()
            {
                if (!IsDisposed)
                {
                    Console.WriteLine($"[!] [Деструктор] Ресурс файла '{Name}' освобожден в деструкторе.");
                }
            }
        }

        // Тип ресурса 2: Сетевой порт
        public class NetworkPortResource : ISystemResource
        {
            public string Name { get; private set; }
            public bool IsDisposed { get; private set; }

            public NetworkPortResource(string name)
            {
                Name = name;
                IsDisposed = false;
                Console.WriteLine($"[+] Создан сетевой порт: {Name}");
            }

            public void Dispose()
            {
                if (IsDisposed) return;
                Console.WriteLine($"[-] Сетевой порт '{Name}' закрыт.");
                IsDisposed = true;
                GC.SuppressFinalize(this);
            }

            ~NetworkPortResource()
            {
                if (!IsDisposed)
                {
                    Console.WriteLine($"[!] [Деструктор] Сетевой порт '{Name}' освобожден в деструкторе.");
                }
            }
        }

        // Общий менеджер ресурсов
        public class SystemResourceManager : IDisposable
        {
            private List<ISystemResource> _resources = new List<ISystemResource>();
            private bool _disposed = false;

            public void Register(ISystemResource resource)
            {
                _resources.Add(resource);
            }

            public void ReleaseAll()
            {
                Console.WriteLine("\n[Менеджер] Освобождение всех зарегистрированных ресурсов:");
                foreach (var res in _resources)
                {
                    if (!res.IsDisposed)
                    {
                        res.Dispose();
                    }
                    else
                    {
                        Console.WriteLine($"[Менеджер] Ресурс '{res.Name}' уже был освобожден ранее.");
                    }
                }
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    ReleaseAll();
                    _resources.Clear();
                    _disposed = true;
                    GC.SuppressFinalize(this);
                    Console.WriteLine("[Менеджер] Сам менеджер ресурсов завершил работу.");
                }
            }

            ~SystemResourceManager()
            {
                Console.WriteLine("[!] [Деструктор Менеджера] Аварийная очистка ресурсов.");
                Dispose();
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ ИТОГОВОГО ПРОЕКТА: МЕНЕДЖЕР РЕСУРСОВ ===");

            using (SystemResourceManager manager = new SystemResourceManager())
            {
                // 1. Создание нескольких типов ресурсов
                TextFileResource file1 = new TextFileResource("Config.json");
                TextFileResource file2 = new TextFileResource("Log.txt");
                NetworkPortResource port1 = new NetworkPortResource("Port_8080");

                // 2. Регистрация в менеджере
                manager.Register(file1);
                manager.Register(file2);
                manager.Register(port1);

                // 3. Ручное освобождение одного из ресурсов для проверки защиты от повторного освобождения
                Console.WriteLine("\nРучное досрочное закрытие файла Log.txt:");
                file2.Dispose();

                // 4. Менеджер освобождает оставшиеся при выходе из using
            }

            Console.WriteLine("\nПринудительный запуск сборщика мусора:");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Сборка мусора и проект завершены успешно!");
        }
    }
    #endregion
}
