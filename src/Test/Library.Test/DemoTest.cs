using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;
namespace Library.Test
{
    public class Tests
    {
        private Recipe recipe;

        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            recipe = new Recipe();
            Product product = new Product("Café con leche", 50);
            recipe.FinalProduct = product;
            Step step = new Step(new Product("Leche",20) , 1, new Equipment("Cafetera", 5), 3);
            Step step2 = new Step(new Product("Café",25) , 2, new Equipment("Cafetera", 5), 3);
            recipe.AddStep(step);
            recipe.AddStep(step2);
        }

        [Test]
        public void DemoTest() // Cambiá el nombre para indicar qué estás probando
        {
            int a = 1;
            int b = 2;

            Assert.AreEqual(a + b, 3);
        }

        [Test]
        public void CostTest() // Cambiá el nombre para indicar qué estás probando
        {
            //Agregamos test para chequear que el valor de recipe.GetProductionCost() no es 0 
            Assert.AreNotEqual(recipe.GetProductionCost() , 0);
        }
    }
}