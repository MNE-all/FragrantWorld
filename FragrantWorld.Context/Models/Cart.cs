using FragrantWorldWinFormsApp.Models;
using System.ComponentModel.DataAnnotations;

namespace FragrantWorld.Context.Models
{
    /// <summary>
    /// Сущность товара корзины
    /// </summary>
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public User? Client { get; set; }
        /// <summary>
        /// Связь один ко многим
        /// </summary>
        public int? ClientId { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Связь один ко многим
        /// </summary>
        [Required]
        public string ProductArticleNumber { get; set; }
        public int Amount { get; set; }
    }
}
