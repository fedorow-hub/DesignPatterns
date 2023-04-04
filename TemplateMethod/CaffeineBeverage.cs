namespace TemplateMethod
{
    public abstract class CaffeineBeverage : Beverage
    {
        public sealed override void PrepareRecipe() //шаблонный метод, поскольку служит шаблоном для алгоритма
        {                                           //объявляется с ключевыми словами sealed override, чтобы
            BoilWater();                            //субклассы не могли изменить последовательность шагов
            Brew();         //каждый шаг алгоритма представлен методом                                  
            PourInCup();
            AddCondiments();
            Hook();
        }
        public abstract void Brew();            //в данном примере две операции должны быть определены в субклассах

        public abstract void AddCondiments();
        public void BoilWater()                     //конкретные реализации в абстрактном классе, которые могут быть 
        {                                           //переопределены в субклассах
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void Hook() { }      //конкретный метод, который не делает ничего
                                    //субклассы могут как переопределять данный метод "перехватчик", так и не делать этого
        //«Перехватчиком» называется метод, объявленный абстрактным классом,
        //но имеющий пустую реализацию(или реализацию по умолчанию). 
    }
}
