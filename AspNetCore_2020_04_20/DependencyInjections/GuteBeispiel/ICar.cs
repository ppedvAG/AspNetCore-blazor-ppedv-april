namespace DependencyInjections.GuteBeispiel
{
    public interface ICar
    {
        string Brand { get; set; }

        string Color { get; set; }

        void Show();
    }
}