using FragrantWorld.Context.Models;
using System.ComponentModel.DataAnnotations;

namespace FragrantWorld.Windows.UserControlls.Models
{
    /// <summary>
    /// Модель для удобной работы с CartControl
    /// </summary>
    public class CartModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Артикль
        /// </summary>
        public string ArticleNumber { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Цена за единицу
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Текущая скидка
        /// </summary>
        public float CurrentDiscount { get; set; }
        /// <summary>
        /// <inheritdoc cref="Models.Manufacturer"/>
        /// </summary>
        public Manufacturer Manufacturer { get; set; }
        /// <summary>
        /// Связь один к многим
        /// </summary>
        public int ManufacturerId { get; set; }
        /// <summary>
        /// Количество единиц на складе
        /// </summary>
        public int StorageAmount { get; set; }
        /// <summary>
        /// Адрес изображения
        /// </summary>
        public string ImageURL { get; set; }


        public int Amount { get; set; }
    }
}
