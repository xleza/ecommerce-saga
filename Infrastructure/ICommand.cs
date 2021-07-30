namespace Infrastructure
{
    public interface ICommand<out TId>
    {
        public TId Id { get; }
        public void Validate();
    }
}
