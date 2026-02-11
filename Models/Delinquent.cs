using System.ComponentModel.DataAnnotations;

namespace College.Models;

public enum Violation
{
    Smoking, Gooning, Sleeping, Drugs, Alcohol
}

public class Delinquent
{
    [Key]
    public int DelinquentsId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime EventDate { get; set; }
    public bool isStudent { get; set; }
    public required string PunishmentType { get; set; }
    public int PunishmentLenght { get; set; }
    public required string Description { get; set; }

}