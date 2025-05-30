using System;

namespace OperatorOverloadingDemo
{
    // Interface that defines a contract for objects that can be "quit"
    public interface IQuittable
    {
        // Method signature for Quit operation
        // Classes implementing this interface must provide their own implementation
        void Quit();
    }
}