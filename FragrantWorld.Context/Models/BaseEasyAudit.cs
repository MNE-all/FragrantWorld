using System.ComponentModel.DataAnnotations;

namespace FragrantWorldWinFormsApp.Models
{
    /// <summary>
    /// Базовый простой класс, содержащий: <inheritdoc cref="Id"/>, <inheritdoc cref="Name"/>
    /// </summary>
    public class BaseEasyAudit
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
