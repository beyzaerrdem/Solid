using System;

namespace InterfaceSegragation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IRepository
    {
        void Add();
    }

    public interface ICategoryRepository:IRepository //IRepository'i parçaladık
    {
        void GetCategories();
    }

    public interface IProductRepository:IRepository //Add methodunu kullanmak için kalıtım
    {
        void GetProducts();
    }

    public class CategoryRepository:ICategoryRepository
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void GetCategories()
        {
            Console.WriteLine("List Category");
        }

        //public void GetCategories()      //ProductRepositoryde GetCategories kullanılmıyor bu yüzden interface'i parçalamak gerekir
        //{
        //    Console.WriteLine("List Category");
        //}

        //public void GetProducts()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class ProductRepository:IProductRepository
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void GetProducts()
        {
            Console.WriteLine("List Product");
        }
    }
}
