namespace Es47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.GetNome();
            p.GetCognome();
            p.GetEta();

            p.GetDettagli();
            Console.WriteLine("Premere INVIO per uscire dal programma");
            Console.ReadLine();
        }
    }
}

class Persona
{
    private string _nome;
    private string _cognome;
    private byte _eta;

    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }
    public void GetNome()
    {
        Console.WriteLine("Inserire il nome della persona: ");
        string input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
        {
            _nome = input;
        }
        else
        {
            Console.WriteLine("L'input non è valido. Inserire solo lettere.");
            GetNome();
        }
    }

    public void GetCognome()
    {
        Console.WriteLine("Inserire il cognome della persona: ");
        string input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
        {
            _cognome = input;
        }
        else
        {
            Console.WriteLine("L'input non è valido. Inserire solo lettere.");
            GetCognome();
        }
    }
    public void GetEta()
    {
        Console.WriteLine("Inserire l'età della persona: ");
        string input = Console.ReadLine();

        bool success = byte.TryParse(input, out byte eta);
        if (success)
        {
            _eta = eta;
        }
        else
        {
            Console.WriteLine("L'input non è valido. Inserire un numero.");
            GetEta(); 
        }
    }

    public void GetDettagli()
    {
        Console.WriteLine($"I dati da te inseriti: {_nome} {_cognome} {_eta} anni");
    }

}
    