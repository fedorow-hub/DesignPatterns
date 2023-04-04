﻿using CompositePatternInOneProject.DucksAndGooses;

namespace CompositePatternInOneProject;

public class DuckFactory : AbstractDuckFactory
{
    public override IQuackable CreateDuckCall()
    {
        return new DuckCall();
    }

    public override IQuackable CreateGoose()
    {
        return new GooseAdapter(new Goose());
    }

    public override IQuackable CreateMallardDuck()
    {
        return new MallardDuck();
    }

    public override IQuackable CreateRedheadDuck()
    {
        return new RedheadDuck();
    }

    public override IQuackable CreateRubberDuck()
    {
        return new RubberDuck();
    }
}
