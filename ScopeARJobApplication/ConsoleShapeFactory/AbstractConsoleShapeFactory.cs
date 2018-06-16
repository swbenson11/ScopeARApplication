namespace ScopeARJobApplication.ConsoleShape
{
    public abstract class AbstractConsoleShapeFactory
    {
        /// <summary>
        /// Main function for returning ConsoleShape
        /// </summary>
        /// <param name="shapeType">The type of shape to create, expects ConsoleShapeEnum</param>
        /// <param name="shapeSize">the size of the shape to create</param>
        /// <returns>The new ConsoleShape. Call ConsoleShape.GetShape() to output pattern. </returns>
        public abstract IConsoleShape GetConsoleShape(ConsoleShapeEnum shapeType, int shapeSize);
    }
}
