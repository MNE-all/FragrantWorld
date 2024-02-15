using System.ComponentModel.DataAnnotations;

namespace FragrantWorldWinFormsApp.Models
{
    /// <summary>
    /// Сущность продукта
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Артикль
        /// </summary>
        [Key]
        public string ArticleNumber { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// <inheritdoc cref="Models.UnitOfMeasurement"/>
        /// </summary>
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        /// <summary>
        /// Цена за единицу
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Текущая скидка
        /// </summary>
        public float CurrentDiscount { get; set; }
        /// <summary>
        /// Размер максимально возможной скидки
        /// </summary>
        public float MaxDiscount { get; set;}
        /// <summary>
        /// <inheritdoc cref="Models.Manufacturer"/>
        /// </summary>
        public Manufacturer Manufacturer { get; set;}
        /// <summary>
        /// Связь один к многим
        /// </summary>
        public int ManufacturerId { get; set; }

        /// <summary>
        /// <inheritdoc cref="Models.Supplier"/>
        /// </summary>
        public Supplier Supplier { get; set; }
        /// <summary>
        /// Связь один к многим
        /// </summary>
        public int SupplierId { get; set; }
        /// <summary>
        /// <inheritdoc cref="ProductCategory"/>
        /// </summary>
        public ProductCategory Category { get; set; }
        /// <summary>
        /// Связь один к многим
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Количество единиц на складе
        /// </summary>
        public int StorageAmount { get; set; }
        /// <summary>
        /// Адрес изображения
        /// </summary>
        public string ImageURL { get; set; }
    }
}
