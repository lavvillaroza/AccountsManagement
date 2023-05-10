﻿Public Class BRCollectionReportBuyerParticipant
    Private _BRCollReportNumber As Long
    Public Property BRCollReportNumber() As Long
        Get
            Return _BRCollReportNumber
        End Get
        Set(ByVal value As Long)
            _BRCollReportNumber = value
        End Set
    End Property

    Private _Participant As AMParticipants
    Public Property Participant() As AMParticipants
        Get
            Return _Participant
        End Get
        Set(ByVal value As AMParticipants)
            _Participant = value
        End Set
    End Property

    Private _BRCollReportDetails As List(Of BRCollectionReportPurchasesDetails)
    Public Property BRCollReportDetails() As List(Of BRCollectionReportPurchasesDetails)
        Get
            Return _BRCollReportDetails
        End Get
        Set(ByVal value As List(Of BRCollectionReportPurchasesDetails))
            _BRCollReportDetails = value
        End Set
    End Property

End Class
