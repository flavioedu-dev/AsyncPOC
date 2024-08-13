namespace AsyncPOC.Application;

public class AsyncMethods
{
    public async Task ExecMethods()
    {
        AnoPar();

        ContandoLentamente();
    }

    private async Task<bool> AnoPar()
    {
        await Task.Delay(TimeSpan.FromSeconds(5));
        bool res = DateTime.Now.Year % 2 == 0 ? true : false;
        Console.WriteLine("O ano é par? {0}", res ? "sim" : "não");
        return await Task.FromResult(res);
    }

    private async Task ContandoLentamente()
    {
        int cont = 0;
        while (++cont <= 10)
        {
            Console.WriteLine("Cont: {0}", cont);
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}