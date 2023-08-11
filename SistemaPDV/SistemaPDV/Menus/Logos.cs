namespace SistemaPDV.Menus;

internal class Logos
{
    public void ExibirLogoInicial()
    {
        Console.WriteLine(@"

 __         __            ______   ______     ______     __  __    
/\ \       /\ \          /\__  _\ /\  ___\   /\  ___\   /\ \_\ \   
\ \ \____  \ \ \____     \/_/\ \/ \ \  __\   \ \ \____  \ \  __ \  
 \ \_____\  \ \_____\       \ \_\  \ \_____\  \ \_____\  \ \_\ \_\ 
  \/_____/   \/_____/        \/_/   \/_____/   \/_____/   \/_/\/_/ 
                                                                   
Developed by: Leo Silka
");
    }

    public void TelaDeCarregamento()
    {
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
    }
}
