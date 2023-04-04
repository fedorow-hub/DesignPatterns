using System.Runtime.Serialization;

namespace GrpcServicewhithProxy
{
    public interface IState: ISerializable
    {
        public void InsertQuarter();
        public void EjectQuarter();
        public void TurnCrank();
        public void Dispense();
        public void Refill();
    }
}
