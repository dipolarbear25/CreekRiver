// This using statement is necessary to use "Required" in the class below
using System.ComponentModel.DataAnnotations;

namespace CreekRiver.Models;

public class CampsiteType
{
    public int Id { get; set; }
    [Required]
    public string CampsiteTypeName { get; set; }
    public int MaxReservationDays { get; set; }
    public decimal FeePerNight { get; set; }
}