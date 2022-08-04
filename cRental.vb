'Class code CRental
Public Class cRental
    'Varible name
    Private flat As Integer
    Private house As String
    Private cost As Double
    Private numberofroom As String
    Private location As String
    Public Property cFlat() As Integer
        Set(value As Integer)
            flat = value

        End Set
        Get
            Return flat
        End Get
    End Property

    Public Property chouse() As Integer
        Set(value As Integer)
            house = value

        End Set
        Get
            Return house
        End Get
    End Property

    Public Property cCost() As Double
        Set(value As Double)
            cost = value

        End Set
        Get
            Return cost
        End Get
    End Property

    Public Property cnumberofroom() As Integer
        Set(value As Integer)
            numberofroom = value

        End Set
        Get
            Return numberofroom
        End Get
    End Property


    Public Property clocation() As String
        Set(value As String)
            location = value

        End Set
        Get
            Return location
        End Get
    End Property

End Class

'Class code cCustomer
Public Class cCustomer

    Private CustomerID As String
    Private Firstname As String
    Private Surname As String
    Private Address As String
    Private InvoiceNo As Double
    Private Town As String
    Private ProveofID As String
    Private deposit As Double
    Private downPayment As Double
    Private Datebill As Double
    Private DueDatebill As Double

    Public Property cCustomerID() As String
        Set(value As String)
            CustomerID = value

        End Set
        Get
            Return CustomerID
        End Get
    End Property


    Public Property cFirstname() As String
        Set(value As String)
            Firstname = value

        End Set
        Get
            Return Firstname
        End Get
    End Property

    Public Property cSurname() As String
        Set(value As String)
            Surname = value

        End Set
        Get
            Return Surname
        End Get
    End Property

    Public Property cAddress() As String
        Set(value As String)
            Address = value

        End Set
        Get
            Return Address
        End Get
    End Property


    Public Property cInvoiceNo() As Double
        Set(value As Double)
            InvoiceNo = value

        End Set
        Get
            Return InvoiceNo
        End Get
    End Property

    Public Property cTown() As String
        Set(value As String)
            Town = value

        End Set
        Get
            Return Town
        End Get
    End Property

    Public Property cProveofID() As String
        Set(value As String)
            ProveofID = value

        End Set
        Get
            Return ProveofID
        End Get
    End Property

    Public Property cdeposit() As Double
        Set(value As Double)
            deposit = value

        End Set
        Get
            Return deposit
        End Get
    End Property

    Public Property cdownPayment() As Double
        Set(value As Double)
            downPayment = value

        End Set
        Get
            Return downPayment
        End Get
    End Property

    Public Property cDatebill() As Double
        Set(value As Double)
            Datebill = value

        End Set
        Get
            Return Datebill
        End Get
    End Property

    Public Property cDueDatebill() As Double
        Set(value As Double)
            DueDatebill = value

        End Set
        Get
            Return DueDatebill
        End Get
    End Property


End Class

'Class code cUtilities
Public Class cUtilities
    Private localTax As Double
    Private waterBill As Double
    Private electricity As Double
    Private Rent As Double

    Public Property clocalTax() As Double
        Set(value As Double)
            localTax = value

        End Set
        Get
            Return localTax
        End Get
    End Property


    Public Property cwaterBill() As Double
        Set(value As Double)
            waterBill = value

        End Set
        Get
            Return waterBill
        End Get
    End Property

    Public Property celectricity() As Double
        Set(value As Double)
            electricity = value

        End Set
        Get
            Return electricity
        End Get
    End Property

    Public Property cRent() As Double
        Set(value As Double)
            Rent = value

        End Set
        Get
            Return Rent
        End Get
    End Property


End Class


'Class code BillingCost
Public Class BillingCost
    Public iCustomer As New cCustomer
    Public iRental As New cRental
    Public iUtilities As New cUtilities

    Public Overridable Function TotalBill()
        Return (iCustomer.cdeposit - iCustomer.cdownPayment + (iRental.cCost * iRental.cnumberofroom) + iUtilities.clocalTax +
            iUtilities.celectricity + iUtilities.cwaterBill + iUtilities.cRent)
    End Function


End Class