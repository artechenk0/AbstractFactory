namespace ТвояЕда
{
    public abstract class Burger
    {
        public abstract string CreateProductA();
        public abstract string CreateProductB();
        public abstract string CreateProductC();
        public abstract string CreateProductD();
        public abstract string CreateProductE();
    }
    public class SqrHumburger : Burger
    {
        public override string CreateProductA() => new SqrBulochka().Name;
        public override string CreateProductB() => new ChickencCutlet().Name;
        public override string CreateProductC() => new Cheese().Name;
        public override string CreateProductD() => new GarlicSauce().Name;
        public override string CreateProductE() => new Cucumbers().Name;
    }
    public class RoundHumburger : Burger
    {
        public override string CreateProductA() => new RoundBulochka().Name;
        public override string CreateProductB() => new RoundBulochka().Name;
        public override string CreateProductC() => new Cheese().Name;
        public override string CreateProductD() => new CheeseSauce().Name;
        public override string CreateProductE() => new Tomatoes().Name;
    }
    public class BigMac : Burger
    {
        public override string CreateProductA() => new RoundBulochka().Name;
        public override string CreateProductB() => new BeefCutlet().Name;
        public override string CreateProductC() => new Onion().Name;
        public override string CreateProductD() => new Bacon().Name;
        public override string CreateProductE() => new Cucumbers().Name;
    }
    public class TexasBurger : Burger
    {
        public override string CreateProductA() => new SqrBulochka().Name;
        public override string CreateProductB() => new BeefCutlet().Name;
        public override string CreateProductC() => new Cheese().Name;
        public override string CreateProductD() => new CheeseSauce().Name;
        public override string CreateProductE() => new Tomatoes().Name;
    }
    abstract class Bulochka { public abstract string Name { get; } }
    class SqrBulochka : Bulochka { public override string Name => "Квадратная булочка"; }
    class RoundBulochka : Bulochka { public override string Name => "Круглая булочка"; }

    abstract class Sauce { public abstract string Name { get; } }
    class GarlicSauce : Sauce { public override string Name => "Чесночный соус"; }
    class CheeseSauce : Sauce { public override string Name => "Сырный соус"; }

    abstract class Vegetables { public abstract string Name { get; } }
    class Cucumbers : Vegetables { public override string Name => "Огурцы"; }
    class Tomatoes : Vegetables { public override string Name => "Помидоры"; }
    class Onion : Vegetables { public override string Name => "Лук репчатый"; }

    abstract class Cutlet { public abstract string Name { get; } }
    class ChickencCutlet : Cutlet { public override string Name => "Куриная котлета"; }
    class BeefCutlet : Cutlet { public override string Name => "Говяжья котлета"; }

    abstract class Additionally { public abstract string Name { get; } }
    class Cheese : Additionally { public override string Name => "Сыр"; }
    class Bacon : Additionally { public override string Name => "Бекон (нарезка)"; }





}

