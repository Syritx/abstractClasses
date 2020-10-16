using System;
namespace returnType
{
    abstract class Entity
    {
        public enum EntityType {TestFunc, HelloWorld};
        public EntityType type;

        public virtual void Render(bool canPrint){
            if (canPrint) Console.WriteLine("rendering\n");
        }

        public virtual EntityType GetEntityType() {
            return type;
        }
    }
}
