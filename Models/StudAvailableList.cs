using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudAvailableList
{
    public int Id { get; set; }

    public int? Studid { get; set; }

    public decimal? Hsc { get; set; }

    public string? HscYear { get; set; }

    public decimal? Hssc { get; set; }

    public string? HsscYear { get; set; }

    public int? Cet { get; set; }

    public string? CetYear { get; set; }

    public int? Aieee { get; set; }

    public string? AieeeYear { get; set; }

    public decimal? Diploma { get; set; }

    public string? DiplomaYear { get; set; }

    public decimal? Ssc { get; set; }

    public string? SscYear { get; set; }

    public decimal? Be1 { get; set; }

    public string? Be1Year { get; set; }

    public decimal? Be2 { get; set; }

    public string? Be2Year { get; set; }

    public decimal? Be3 { get; set; }

    public string? Be3Year { get; set; }

    public decimal? Be4 { get; set; }

    public string? Be4Year { get; set; }

    public decimal? Me1 { get; set; }

    public string? Me1Year { get; set; }

    public decimal? Mca2 { get; set; }

    public string? Mca2Year { get; set; }

    public decimal? Mca3 { get; set; }

    public string? Mca3Year { get; set; }

    public decimal? Mba1 { get; set; }

    public string? Mba1Year { get; set; }

    public decimal? Mba2 { get; set; }

    public string? Mba2Year { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }

    public string? Semester { get; set; }

    public string? SemesterMarks { get; set; }
}
