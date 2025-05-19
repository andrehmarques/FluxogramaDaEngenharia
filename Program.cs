string escolhaUsuario;

do
{
    Console.WriteLine("O objeto está se movendo? Sim ou Não: ");
    escolhaUsuario = Console.ReadLine()!.ToUpper();

    if (escolhaUsuario == "S" || escolhaUsuario == "N")
    {
        break;
    }

    else
    {
        Console.WriteLine("Resposta inválida. Digite S para sim ou N para não.");
    }
} while (true);

if (escolhaUsuario == "S")
{
    do
    {
        Console.WriteLine("O objeto deveria se mover? Sim ou Não: ");
        escolhaUsuario = Console.ReadLine()!.ToUpper();

        if (escolhaUsuario == "S" || escolhaUsuario == "N")
        {
            break;
        }

        else
        {
            Console.WriteLine("Resposta inválida. Digite S para sim ou N para não.");
        }

    } while (true);

    if (escolhaUsuario == "S")
    {
        Console.WriteLine("Ótimo!");

    }

    else
    {
        Console.WriteLine("Use Silver Tape!");
    }
}

else
{
    do
    {
        Console.WriteLine("O objeto deveria se mover? Sim ou Não: ");
        escolhaUsuario = Console.ReadLine()!.ToUpper();

        if (escolhaUsuario == "S" || escolhaUsuario == "N")
        {
            break;
        }

        else
        {
            Console.WriteLine("Resposta inválida. Digite S para sim ou N para não.");
        }

    } while (true);

    if (escolhaUsuario == "N")
    {
        Console.WriteLine("Ótimo!");
    }

    else
    {
        Console.WriteLine("Use WD-40!");
    }

}