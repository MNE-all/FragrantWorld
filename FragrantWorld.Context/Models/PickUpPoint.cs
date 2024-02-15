using System.ComponentModel.DataAnnotations;

namespace FragrantWorldWinFormsApp.Models
{
    /// <summary>
    /// Сущность пункта выдачи
    /// </summary>
    public class PickUpPoint
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Почтовый индекс
        /// </summary>
        [Required]
        public string Index { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        [Required]
        public string City { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        [Required]
        public string Street { get; set; }
        /// <summary>
        /// Номер дома
        /// </summary>
        [Required]
        public string Number { get; set; }

    }
}
