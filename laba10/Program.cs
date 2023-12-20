student sabina = new student("Sabina", 2023, "pushkina 9", 37 - 80, 2, "eng");
student valera = new student("Valera", 2021, "pushkina 9", 36 - 80, 2, "rus");
student andrey = new student("Andrey", 2022, "pushkina 9", 35 - 80, 2, "rus");
student[] cap = new student[3] { sabina, valera, andrey };
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(cap[i].fio);
}
Console.WriteLine("Введите факультет; eng or rus");
string? faculet = Console.ReadLine();
for (int i = 0; i < cap.Length; i++)
{
    if (cap[i].FAKULTET == faculet)
    {

        Console.WriteLine($"Студенты заданого факультета:{cap[i].fio}");
    }
}
Console.WriteLine("Введите год");
int? data_postupleniy = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 6; i++)
{
    if (cap[i].DATA_POSTUPLENIY > data_postupleniy)
    {
        Console.WriteLine($"Список студентов:{cap[i].fio}");
    }
}
class student
{
    private string FIO;
    private int data_postupleniy;
    private object adress;
    private int telefon;
    private int kurs;
    private string fakultet;
    public student(string FIO, int data_postupleniy, object adress, int telefon, int kurs, string fakultet)
    {
        this.FIO = FIO;
        this.data_postupleniy = data_postupleniy;
        this.adress = adress;
        this.telefon = telefon;
        this.kurs = kurs;
        this.fakultet = fakultet;
    }
    public string fio
    {
        get
        {
            return FIO;
        }
        set
        {
            FIO = value;
        }
    }

    public int DATA_POSTUPLENIY
    {
        get
        {
            return data_postupleniy;
        }
        set
        {
            data_postupleniy = value;
        }
    }
    public object ADRESS
    {
        get
        {
            return adress;
        }
    }
    public int TELEFON
    {
        get
        {
            return telefon;
        }
        set
        {
            telefon = value;
        }
    }
    public int KURS
    {
        set
        {
            kurs = value;
        }
    }
    public string FAKULTET
    {
        get
        {
            return fakultet;
        }
    }
}