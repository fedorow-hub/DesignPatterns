namespace FactoryMethod.PizzaStores
{
    public abstract class PizzaStore //сделали класс абстрактным
    {
        public Pizza.Pizza orderPizza(String type)
        {
            Pizza.Pizza pizza;
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza.Pizza createPizza(String type); //«Фабричный метод» стал абстрактным методом PizzaStore.
    }
}
