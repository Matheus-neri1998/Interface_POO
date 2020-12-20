namespace Interface_POO.Classes
{
    public interface ICarrinho 
    {
         // CRUD

         // Create

         void Cadastrar (Produto produto);

         // Read

         void Listar ();

         // Update

         void Alterar(int cod);

         // Delete

         void Deletar(int cod);
    }
}