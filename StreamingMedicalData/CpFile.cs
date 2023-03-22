using System.Xml.Serialization;

namespace StreamingMedicalData;

[XmlRoot(ElementName = "Practice")]
public class Practice
{

    [XmlElement(ElementName = "branch")]
    public long Branch { get; set; }

    [XmlElement(ElementName = "no")]
    public long No { get; set; }

    [XmlElement(ElementName = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "healthRegion")]
    public long HealthRegion { get; set; }

    [XmlElement(ElementName = "address")]
    public string Address { get; set; }
}

[XmlRoot(ElementName = "Patient")]
public class Patient
{

    [XmlElement(ElementName = "EGN")]
    public string EGN { get; set; }

    [XmlElement(ElementName = "dateBirth")]
    public DateTime DateBirth { get; set; }

    [XmlElement(ElementName = "Sex")]
    public long Sex { get; set; }

    [XmlElement(ElementName = "Given")]
    public object Given { get; set; }

    [XmlElement(ElementName = "Sur")]
    public object Sur { get; set; }

    [XmlElement(ElementName = "Family")]
    public object Family { get; set; }

    [XmlElement(ElementName = "Address")]
    public object Address { get; set; }

    [XmlElement(ElementName = "Notes")]
    public object Notes { get; set; }

    [XmlElement(ElementName = "personType")]
    public long PersonType { get; set; }
}

[XmlRoot(ElementName = "Sender")]
public class Sender
{

    [XmlElement(ElementName = "Practice")]
    public Practice Practice { get; set; }

    [XmlElement(ElementName = "uin")]
    public long Uin { get; set; }

    [XmlElement(ElementName = "speciality")]
    public long Speciality { get; set; }

    [XmlElement(ElementName = "NumNapr")]
    public long NumNapr { get; set; }

    [XmlElement(ElementName = "deputyUin")]
    public long DeputyUin { get; set; }
}

[XmlRoot(ElementName = "sendDiagnose")]
public class SendDiagnose
{

    [XmlElement(ElementName = "primary")]
    public string Primary { get; set; }

    [XmlElement(ElementName = "secondary")]
    public string Secondary { get; set; }
}

[XmlRoot(ElementName = "diagnose")]
public class Diagnose
{

    [XmlElement(ElementName = "primary")]
    public string Primary { get; set; }

    [XmlElement(ElementName = "secondary")]
    public string Secondary { get; set; }
}

[XmlRoot(ElementName = "In")]
public class In
{

    [XmlElement(ElementName = "sendDiagnose")]
    public List<SendDiagnose> SendDiagnose { get; set; }

    [XmlElement(ElementName = "sendUrgency")]
    public long SendUrgency { get; set; }

    [XmlElement(ElementName = "sendClinicalPath")]
    public string SendClinicalPath { get; set; }

    [XmlElement(ElementName = "uin")]
    public long Uin { get; set; }

    [XmlElement(ElementName = "examinationDate")]
    public DateTime ExaminationDate { get; set; }

    [XmlElement(ElementName = "diagnose")]
    public Diagnose Diagnose { get; set; }

    [XmlElement(ElementName = "urgency")]
    public long Urgency { get; set; }

    [XmlElement(ElementName = "clinicalPath")]
    public string ClinicalPath { get; set; }

    [XmlElement(ElementName = "NZOKPay")]
    public long NZOKPay { get; set; }

    [XmlElement(ElementName = "inMedicalWard")]
    public double InMedicalWard { get; set; }

    [XmlElement(ElementName = "entryDate")]
    public DateTime EntryDate { get; set; }

    [XmlElement(ElementName = "severity")]
    public long Severity { get; set; }

    [XmlElement(ElementName = "delay")]
    public long Delay { get; set; }

    [XmlElement(ElementName = "payer")]
    public long Payer { get; set; }

    [XmlElement(ElementName = "IZYear")]
    public long IZYear { get; set; }

    [XmlElement(ElementName = "IZNo")]
    public long IZNo { get; set; }

    [XmlElement(ElementName = "Patient")]
    public Patient Patient { get; set; }

    [XmlElement(ElementName = "patientBranch")]
    public long PatientBranch { get; set; }

    [XmlElement(ElementName = "patientHRegion")]
    public long PatientHRegion { get; set; }

    [XmlElement(ElementName = "longype")]
    public long longype { get; set; }

    [XmlElement(ElementName = "Sender")]
    public Sender Sender { get; set; }

    [XmlElement(ElementName = "sendDate")]
    public DateTime SendDate { get; set; }

    [XmlElement(ElementName = "plannedNo")]
    public long PlannedNo { get; set; }

    [XmlElement(ElementName = "birthWeight")]
    public long BirthWeight { get; set; }

    [XmlElement(ElementName = "motherIZYear")]
    public long MotherIZYear { get; set; }

    [XmlElement(ElementName = "motherIZNo")]
    public long MotherIZNo { get; set; }

    [XmlElement(ElementName = "ageInDays")]
    public long AgeInDays { get; set; }

    [XmlElement(ElementName = "weightInGrams")]
    public long WeightInGrams { get; set; }
}

[XmlRoot(ElementName = "dead")]
public class Dead
{

    [XmlElement(ElementName = "primary")]
    public string Primary { get; set; }
}

[XmlRoot(ElementName = "epicrisis")]
public class Epicrisis
{

    [XmlElement(ElementName = "history")]
    public string History { get; set; }

    [XmlElement(ElementName = "fairCondition")]
    public string FairCondition { get; set; }

    [XmlElement(ElementName = "clinicalExaminations")]
    public string ClinicalExaminations { get; set; }

    [XmlElement(ElementName = "consultations")]
    public string Consultations { get; set; }

    [XmlElement(ElementName = "regimen")]
    public string Regimen { get; set; }

    [XmlElement(ElementName = "diseaseCourse")]
    public string DiseaseCourse { get; set; }

    [XmlElement(ElementName = "complications")]
    public string Complications { get; set; }

    [XmlElement(ElementName = "dateOfSurgery")]
    public DateTime DateOfSurgery { get; set; }

    [XmlElement(ElementName = "sampleProtocol")]
    public string SampleProtocol { get; set; }

    [XmlElement(ElementName = "postoperativeStatus")]
    public string PostoperativeStatus { get; set; }

    [XmlElement(ElementName = "dischargeStatus")]
    public string DischargeStatus { get; set; }

    [XmlElement(ElementName = "Recommendations")]
    public string Recommendations { get; set; }

    [XmlElement(ElementName = "checkupAfterDischarge")]
    public string CheckupAfterDischarge { get; set; }

    [XmlElement(ElementName = "GPRecommendations")]
    public string GPRecommendations { get; set; }

    [XmlElement(ElementName = "otherDocuments")]
    public string OtherDocuments { get; set; }

    [XmlElement(ElementName = "doctorsNames")]
    public string DoctorsNames { get; set; }
}

[XmlRoot(ElementName = "outMainDiag")]
public class OutMainDiag
{

    [XmlElement(ElementName = "primary")]
    public string Primary { get; set; }

    [XmlElement(ElementName = "secondary")]
    public string Secondary { get; set; }
}

[XmlRoot(ElementName = "Procedures")]
public class Procedures
{

    [XmlElement(ElementName = "code")]
    public double Code { get; set; }

    [XmlElement(ElementName = "outHosp")]
    public long OutHosp { get; set; }

    [XmlElement(ElementName = "date")]
    public DateTime Date { get; set; }

    [XmlElement(ElementName = "Implant")]
    public Implant Implant { get; set; }

    [XmlElement(ElementName = "ACHIcode")]
    public string ACHIcode { get; set; }
}

[XmlRoot(ElementName = "Out")]
public class Out
{

    [XmlElement(ElementName = "sendDiagnose")]
    public List<SendDiagnose> SendDiagnose { get; set; }

    [XmlElement(ElementName = "sendUrgency")]
    public long SendUrgency { get; set; }

    [XmlElement(ElementName = "sendClinicalPath")]
    public string SendClinicalPath { get; set; }

    [XmlElement(ElementName = "uin")]
    public long Uin { get; set; }

    [XmlElement(ElementName = "examinationDate")]
    public DateTime ExaminationDate { get; set; }

    [XmlElement(ElementName = "diagnose")]
    public List<Diagnose> Diagnose { get; set; }

    [XmlElement(ElementName = "urgency")]
    public long Urgency { get; set; }

    [XmlElement(ElementName = "clinicalPath")]
    public string ClinicalPath { get; set; }

    [XmlElement(ElementName = "NZOKPay")]
    public long NZOKPay { get; set; }

    [XmlElement(ElementName = "inMedicalWard")]
    public double InMedicalWard { get; set; }

    [XmlElement(ElementName = "entryDate")]
    public DateTime EntryDate { get; set; }

    [XmlElement(ElementName = "severity")]
    public long Severity { get; set; }

    [XmlElement(ElementName = "delay")]
    public long Delay { get; set; }

    [XmlElement(ElementName = "payer")]
    public long Payer { get; set; }

    [XmlElement(ElementName = "IZYear")]
    public long IZYear { get; set; }

    [XmlElement(ElementName = "IZNo")]
    public long IZNo { get; set; }

    [XmlElement(ElementName = "outMedicalWard")]
    public double OutMedicalWard { get; set; }

    [XmlElement(ElementName = "outUin")]
    public long OutUin { get; set; }

    [XmlElement(ElementName = "outDate")]
    public DateTime OutDate { get; set; }

    [XmlElement(ElementName = "outType")]
    public long OutType { get; set; }

    [XmlElement(ElementName = "outClinicalPath")]
    public string OutClinicalPath { get; set; }

    [XmlElement(ElementName = "epicrisis")]
    public Epicrisis Epicrisis { get; set; }

    [XmlElement(ElementName = "outMainDiag")]
    public OutMainDiag OutMainDiag { get; set; }

    [XmlElement(ElementName = "outDiags")]
    public List<OutDiags> OutDiags { get; set; }

    [XmlElement(ElementName = "Procedures")]
    public List<Procedures> Procedures { get; set; }

    [XmlElement(ElementName = "bedDays")]
    public long BedDays { get; set; }

    [XmlElement(ElementName = "stateAtDischarge")]
    public long StateAtDischarge { get; set; }

    [XmlElement(ElementName = "Laparoscopic")]
    public long Laparoscopic { get; set; }

    [XmlElement(ElementName = "EndCourse")]
    public long EndCourse { get; set; }

    [XmlElement(ElementName = "Patient")]
    public Patient Patient { get; set; }

    [XmlElement(ElementName = "patientBranch")]
    public long PatientBranch { get; set; }

    [XmlElement(ElementName = "patientHRegion")]
    public long PatientHRegion { get; set; }

    [XmlElement(ElementName = "longype")]
    public long longype { get; set; }

    [XmlElement(ElementName = "Sender")]
    public Sender Sender { get; set; }

    [XmlElement(ElementName = "sendDate")]
    public DateTime SendDate { get; set; }

    [XmlElement(ElementName = "UsedDrug")]
    public List<UsedDrug> UsedDrug { get; set; }

    [XmlElement(ElementName = "HLDateFrom")]
    public DateTime HLDateFrom { get; set; }

    [XmlElement(ElementName = "HLNo")]
    public string HLNo { get; set; }

    [XmlElement(ElementName = "HLTotalDays")]
    public long HLTotalDays { get; set; }

    [XmlElement(ElementName = "ageInDays")]
    public long AgeInDays { get; set; }

    [XmlElement(ElementName = "weightInGrams")]
    public long WeightInGrams { get; set; }

    [XmlElement(ElementName = "BirthPractice")]
    public long BirthPractice { get; set; }

    [XmlElement(ElementName = "BirthNum")]
    public long BirthNum { get; set; }

    [XmlElement(ElementName = "resign")]
    public Resign Resign { get; set; }

    [XmlElement(ElementName = "birthWeight")]
    public long BirthWeight { get; set; }

    [XmlElement(ElementName = "motherIZYear")]
    public long MotherIZYear { get; set; }

    [XmlElement(ElementName = "motherIZNo")]
    public long MotherIZNo { get; set; }

    [XmlElement(ElementName = "outAPr")]
    public long OutAPr { get; set; }

    [XmlElement(ElementName = "dead")]
    public Dead Dead { get; set; }
}

[XmlRoot(ElementName = "outDiags")]
public class OutDiags
{

    [XmlElement(ElementName = "primary")]
    public string Primary { get; set; }

    [XmlElement(ElementName = "secondary")]
    public string Secondary { get; set; }
}

[XmlRoot(ElementName = "Implant")]
public class Implant
{

    [XmlElement(ElementName = "productType")]
    public long ProductType { get; set; }

    [XmlElement(ElementName = "tradeName")]
    public string TradeName { get; set; }

    [XmlElement(ElementName = "referenceNo")]
    public string ReferenceNo { get; set; }

    [XmlElement(ElementName = "manufacturer")]
    public string Manufacturer { get; set; }

    [XmlElement(ElementName = "id_provider")]
    public long IdProvider { get; set; }

    [XmlElement(ElementName = "provider")]
    public string Provider { get; set; }

    [XmlElement(ElementName = "code")]
    public string Code { get; set; }

    [XmlElement(ElementName = "date")]
    public DateTime Date { get; set; }

    [XmlElement(ElementName = "serialNumber")]
    public string SerialNumber { get; set; }

    [XmlElement(ElementName = "stickers")]
    public long Stickers { get; set; }

    [XmlElement(ElementName = "distributorInvoiceNo")]
    public long DistributorInvoiceNo { get; set; }

    [XmlElement(ElementName = "distributorInvoiceDate")]
    public DateTime DistributorInvoiceDate { get; set; }

    [XmlElement(ElementName = "nhifAmount")]
    public double NhifAmount { get; set; }

    [XmlElement(ElementName = "patientAmount")]
    public double PatientAmount { get; set; }

    [XmlElement(ElementName = "totalAmount")]
    public double TotalAmount { get; set; }
}

[XmlRoot(ElementName = "histologicalResult")]
public class HistologicalResult
{

    [XmlElement(ElementName = "code")]
    public double Code { get; set; }

    [XmlElement(ElementName = "date")]
    public DateTime Date { get; set; }

    [XmlElement(ElementName = "note")]
    public string Note { get; set; }
}

[XmlRoot(ElementName = "Ver_Code")]
public class VerCode
{

    [XmlElement(ElementName = "Batch_number")]
    public string BatchNumber { get; set; }

    [XmlElement(ElementName = "quantity_pack")]
    public double QuantityPack { get; set; }
}

[XmlRoot(ElementName = "UsedDrug")]
public class UsedDrug
{

    [XmlElement(ElementName = "date")]
    public DateTime Date { get; set; }

    [XmlElement(ElementName = "code")]
    public string Code { get; set; }

    [XmlElement(ElementName = "quantity")]
    public double Quantity { get; set; }

    [XmlElement(ElementName = "cost")]
    public double Cost { get; set; }

    [XmlElement(ElementName = "ICD_drug")]
    public string ICDDrug { get; set; }

    [XmlElement(ElementName = "date_prescr")]
    public object DatePrescr { get; set; }

    [XmlElement(ElementName = "PracticeCode_Protocol")]
    public long PracticeCodeProtocol { get; set; }

    [XmlElement(ElementName = "No_Protocol")]
    public long NoProtocol { get; set; }

    [XmlElement(ElementName = "date_Protocol")]
    public DateTime DateProtocol { get; set; }

    [XmlElement(ElementName = "type_Protocol")]
    public long TypeProtocol { get; set; }

    [XmlElement(ElementName = "Ver_Code")]
    public VerCode VerCode { get; set; }
}

[XmlRoot(ElementName = "resign")]
public class Resign
{

    [XmlElement(ElementName = "OutRefuse")]
    public long OutRefuse { get; set; }

    [XmlElement(ElementName = "Notes")]
    public string Notes { get; set; }
}

[XmlRoot(ElementName = "Diag")]
public class Diag
{

    [XmlElement(ElementName = "imeMD")]
    public string ImeMD { get; set; }

    [XmlElement(ElementName = "MKB")]
    public string MKB { get; set; }
}

[XmlRoot(ElementName = "Histology")]
public class Histology
{

    [XmlElement(ElementName = "NameHS")]
    public string NameHS { get; set; }

    [XmlElement(ElementName = "CodeHS")]
    public string CodeHS { get; set; }
}

[XmlRoot(ElementName = "Gen_Markers")]
public class GenMarkers
{

    [XmlElement(ElementName = "Name")]
    public List<string> Name { get; set; }

    [XmlElement(ElementName = "Sign")]
    public List<long> Sign { get; set; }
}

[XmlRoot(ElementName = "Choise")]
public class Choise
{

    [XmlElement(ElementName = "No")]
    public long No { get; set; }

    [XmlElement(ElementName = "Checked")]
    public long Checked { get; set; }

    [XmlElement(ElementName = "Text")]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "Evaluation")]
public class Evaluation
{

    [XmlElement(ElementName = "Choise")]
    public List<Choise> Choise { get; set; }
}

[XmlRoot(ElementName = "Part_Chemotherapy")]
public class PartChemotherapy
{

    [XmlElement(ElementName = "date_Diag")]
    public DateTime DateDiag { get; set; }

    [XmlElement(ElementName = "Expand_Diag")]
    public string ExpandDiag { get; set; }

    [XmlElement(ElementName = "Histology")]
    public Histology Histology { get; set; }

    [XmlElement(ElementName = "ECOG")]
    public long ECOG { get; set; }

    [XmlElement(ElementName = "TNM")]
    public string TNM { get; set; }

    [XmlElement(ElementName = "Gen_Markers")]
    public GenMarkers GenMarkers { get; set; }

    [XmlElement(ElementName = "Type_Therapy")]
    public long TypeTherapy { get; set; }

    [XmlElement(ElementName = "Eval_after_Cycle")]
    public long EvalAfterCycle { get; set; }

    [XmlElement(ElementName = "longerval")]
    public long longerval { get; set; }

    [XmlElement(ElementName = "Evaluation")]
    public Evaluation Evaluation { get; set; }
}

[XmlRoot(ElementName = "Prot_Drug")]
public class ProtDrug
{

    [XmlElement(ElementName = "Type_Therapy")]
    public long TypeTherapy { get; set; }

    [XmlElement(ElementName = "ATC_Code")]
    public string ATCCode { get; set; }

    [XmlElement(ElementName = "ATC_Name")]
    public string ATCName { get; set; }

    [XmlElement(ElementName = "Days")]
    public string Days { get; set; }

    [XmlElement(ElementName = "Application_Way")]
    public string ApplicationWay { get; set; }

    [XmlElement(ElementName = "Standart_Dose")]
    public double StandartDose { get; set; }

    [XmlElement(ElementName = "Individual_Dose")]
    public double IndividualDose { get; set; }

    [XmlElement(ElementName = "Cycle_Dose")]
    public double CycleDose { get; set; }

    [XmlElement(ElementName = "All_Dose")]
    public double AllDose { get; set; }
}

[XmlRoot(ElementName = "Accompanying_Drug")]
public class AccompanyingDrug
{

    [XmlElement(ElementName = "Type_Therapy")]
    public long TypeTherapy { get; set; }

    [XmlElement(ElementName = "ATC_Code")]
    public string ATCCode { get; set; }

    [XmlElement(ElementName = "ATC_Name")]
    public string ATCName { get; set; }

    [XmlElement(ElementName = "Single_Dose")]
    public double SingleDose { get; set; }

    [XmlElement(ElementName = "All_Dose")]
    public double AllDose { get; set; }
}

[XmlRoot(ElementName = "Chairman")]
public class Chairman
{

    [XmlElement(ElementName = "Spec")]
    public long Spec { get; set; }

    [XmlElement(ElementName = "UIN")]
    public long UIN { get; set; }

    [XmlElement(ElementName = "DoctorName")]
    public string DoctorName { get; set; }
}

[XmlRoot(ElementName = "Members")]
public class Members
{

    [XmlElement(ElementName = "Spec")]
    public long Spec { get; set; }

    [XmlElement(ElementName = "UIN")]
    public long UIN { get; set; }

    [XmlElement(ElementName = "DoctorName")]
    public string DoctorName { get; set; }
}

[XmlRoot(ElementName = "Protocol_DrugTherapy")]
public class ProtocolDrugTherapy
{

    [XmlElement(ElementName = "Patient")]
    public Patient Patient { get; set; }

    [XmlElement(ElementName = "patientBranch")]
    public long PatientBranch { get; set; }

    [XmlElement(ElementName = "patientHRegion")]
    public long PatientHRegion { get; set; }

    [XmlElement(ElementName = "PracticeZdrRajon")]
    public long PracticeZdrRajon { get; set; }

    [XmlElement(ElementName = "PracticeCode")]
    public long PracticeCode { get; set; }

    [XmlElement(ElementName = "PracticeName")]
    public string PracticeName { get; set; }

    [XmlElement(ElementName = "No_Decision")]
    public long NoDecision { get; set; }

    [XmlElement(ElementName = "date_Decision")]
    public DateTime DateDecision { get; set; }

    [XmlElement(ElementName = "PracticeCode_Protocol")]
    public long PracticeCodeProtocol { get; set; }

    [XmlElement(ElementName = "No_Protocol")]
    public long NoProtocol { get; set; }

    [XmlElement(ElementName = "date_Protocol")]
    public DateTime DateProtocol { get; set; }

    [XmlElement(ElementName = "Diag")]
    public Diag Diag { get; set; }

    [XmlElement(ElementName = "height")]
    public long Height { get; set; }

    [XmlElement(ElementName = "weight")]
    public long Weight { get; set; }

    [XmlElement(ElementName = "BSA")]
    public string BSA { get; set; }

    [XmlElement(ElementName = "Line_Therapy")]
    public long LineTherapy { get; set; }

    [XmlElement(ElementName = "Scheme")]
    public object Scheme { get; set; }

    [XmlElement(ElementName = "Cycle_Count")]
    public long CycleCount { get; set; }

    [XmlElement(ElementName = "Part_Chemotherapy")]
    public PartChemotherapy PartChemotherapy { get; set; }

    [XmlElement(ElementName = "Prot_Drug")]
    public List<ProtDrug> ProtDrug { get; set; }

    [XmlElement(ElementName = "Accompanying_Drug")]
    public List<AccompanyingDrug> AccompanyingDrug { get; set; }

    [XmlElement(ElementName = "Chairman")]
    public Chairman Chairman { get; set; }

    [XmlElement(ElementName = "Members")]
    public List<Members> Members { get; set; }

    [XmlElement(ElementName = "Sign")]
    public long Sign { get; set; }

    [XmlElement(ElementName = "Part_Hematology")]
    public PartHematology PartHematology { get; set; }
}

[XmlRoot(ElementName = "Pred_Marker")]
public class PredMarker
{

    [XmlElement(ElementName = "Choise")]
    public Choise Choise { get; set; }
}

[XmlRoot(ElementName = "Part_Hematology")]
public class PartHematology
{

    [XmlElement(ElementName = "Pred_Marker")]
    public PredMarker PredMarker { get; set; }
}

[XmlRoot(ElementName = "cpFile")]
public class CpFile
{

    [XmlElement(ElementName = "Practice")]
    public Practice Practice { get; set; }

    [XmlElement(ElementName = "fileType")]
    public string FileType { get; set; }

    [XmlElement(ElementName = "dateFrom")]
    public DateTime DateFrom { get; set; }

    [XmlElement(ElementName = "dateTo")]
    public DateTime DateTo { get; set; }

    [XmlElement(ElementName = "In")]
    public List<In> In { get; set; }

    [XmlElement(ElementName = "Out")]
    public List<Out> Out { get; set; }

    [XmlElement(ElementName = "Protocol_DrugTherapy")]
    public List<ProtocolDrugTherapy> ProtocolDrugTherapy { get; set; }
}

