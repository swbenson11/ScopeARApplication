using System;

namespace ScopeARJobApplication.ConsoleShape
{
    /// <summary>
    /// Factory Pattern for creating new ascii console shapes
    /// </summary>
    public class ConsoleShapeFactory : AbstractConsoleShapeFactory
    {
        /// <summary>
        /// Main function for returning ConsoleShape. Returns concrete class. 
        /// </summary>
        /// <param name="shapeType">The type of shape to create, expects ConsoleShapeEnum</param>
        /// <param name="shapeSize">the size of the shape to create</param>
        public override IConsoleShape GetConsoleShape(ConsoleShapeEnum shapeType, int shapeSize)
        {
            switch (shapeType)
            {
                case ConsoleShapeEnum.ChistmasTreeShape:
                    return new ChristmasTreeShape(shapeSize);
                case ConsoleShapeEnum.XShape:
                    return new XShape(shapeSize);
                default:
                    throw new ApplicationException($"Invalid ConsoleShapeInput {shapeType}");
            }
        }

    }
}
