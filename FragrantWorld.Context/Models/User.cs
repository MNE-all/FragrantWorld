using System.ComponentModel.DataAnnotations;

namespace FragrantWorld.Context.Models
{
    /// <summary>
    /// Сущность пользователя
    /// </summary>
    public class User : BaseEasyAudit
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        public string Surname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronomyc { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        [Required]
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        [Required]
        public string Password { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public Role Role { get; set; }

    }
}
