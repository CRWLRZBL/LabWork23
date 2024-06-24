namespace LabWorkLibrary
{
    /// <summary>
    /// Предоставляет методы простых математических действий и площадь прямоугольника
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// 2 в 10 степени
        /// </summary>
        public const int BINARY_FACTOR = 1024;

        #region GetSumMethod
        /// <summary>
        /// Вычисляет сумму двух чисел
        /// </summary>
        /// <param name="x">Первое слагаемое</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public static double GetSum(double x, double y) => x + y;
        #endregion

        #region GetDiffMethod
        /// <summary>
        /// Вычисляет разность двух чисел
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double GetDifference(double x, double y) => x - y;
        #endregion

        #region GetMultMethod
        /// <summary>
        /// Вычисляет произведение двух чисел
        /// </summary>
        /// <param name="x">Первый множитель</param>
        /// <param name="y">Второй множитель</param>
        /// <returns>Произведение</returns>
        public static double GetMultiplication(double x, double y) => x * y;
        #endregion

        #region GetDivMethod
        /// <summary>
        /// Вычисляет частное двух чисел
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель</param>
        /// <returns>Частное</returns>
        /// <exception cref="ArgumentException">Вывод ошибки, при некоректных значениях</exception>
        public static double GetDivision(double x, double y)
        {
            if (y == 0)
                throw new ArgumentException("На 0 делить нельзя");
            return x / y;
        }
        #endregion

        #region GetRectAreaMethod
        /// <summary>
        /// Вычисляет площадь прямоугольника
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <returns>Площадь прямоугольника</returns>
        /// <exception cref="ArgumentException">Вывод ошибки, при некоректных значениях</exception>
        public static double GetRectangleArea(double width, double height)
        {
            if ((width <= 0) || (height <= 0))
                throw new ArgumentException("Некорректные значения");
            return (width * height);
        }
        #endregion
    }
}
