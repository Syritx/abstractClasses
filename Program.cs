using System;
using System.Threading;

namespace returnType
{
    class MainClass
    {
        static Entity[] entities = new Entity[10];
        static int fps = 60;

        public static void Main(string[] args) {

            entities[0] = new TestFunc();
            entities[1] = new HelloWorld();
            MainLoop();
        }

        static void MainLoop() {
            do {
                Thread.Sleep(1000/fps);

                foreach(Entity entity in entities) {
                    if (entity != null) {
                        entity.Render(false);
                        //Console.WriteLine(entity.GetEntityType());
                    }
                }
            }
            while (true);
        }
    }

    class TestFunc : Entity
    {
        public TestFunc() {
            type = EntityType.TestFunc;
        }

        public override void Render(bool can) {
            base.Render(can);
        }

        public override EntityType GetEntityType() {
            return base.GetEntityType();
        }
    }

    class HelloWorld : Entity
    {
        public HelloWorld() {
            type = EntityType.HelloWorld;
        }

        public override void Render(bool can) {
            base.Render(can);
        }

        public override EntityType GetEntityType() {
            return base.GetEntityType();
        }
    }
}
