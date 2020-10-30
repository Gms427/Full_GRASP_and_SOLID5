using System;

namespace Full_GRASP_And_SOLID
{
    /*
    El principio de inversión de dependencia nos dice que clases de alto nivel no deben depender de clases de bajo nivel, sino ambas de abstracciones.
    Las abstracciones no deben depender de detalles, los detalles deben depender de abstracciones.
    Esto sucedia entre la clase ConsolePrinter y la clase Recipe, una dependía de la otra.
    Para solucionar esta dependencia y que el código cumpla con el principio DIP, creamos la interface IContent.
    De esta manera la clase ConsolePrinter no dependería de la clase Recipe, una clase de alto nivel de una de bajo nivel. Ahora ambas dependen de la
    abstracción IContent.
    */
    public interface  IContent
    {
       string GetTextToPrint();
        
    }
}