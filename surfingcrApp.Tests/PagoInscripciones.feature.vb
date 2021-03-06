﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:1.9.0.77
'     SpecFlow Generator Version:1.9.0.0
'     Runtime Version:4.0.30319.33440
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace surfingcrApp.Tests
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class InscripcionesFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("PagoInscripciones.feature",1)
#End ExternalSource
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("es-ES"), "Inscripciones", "Como Steven el surfista, quiero realizar el pago de la inscripción en el momento "& _ 
                    "en que me inscribo en un torneo "&Global.Microsoft.VisualBasic.ChrW(10)&"con el fin de asegurar mi espacio en el evento", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()>  _
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()>  _
        Public Overridable Sub TestInitialize()
            If ((Not (TechTalk.SpecFlow.FeatureContext.Current) Is Nothing)  _
                        AndAlso (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title <> "Inscripciones")) Then
                surfingcrApp.Tests.InscripcionesFeature.FeatureSetup(Nothing)
            End If
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()>  _
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        
        Public Overridable Sub FeatureBackground()
#ExternalSource("PagoInscripciones.feature",7)
#End ExternalSource
            Dim table1 As TechTalk.SpecFlow.Table = New TechTalk.SpecFlow.Table(New String() {"Marca tarjeta"})
            table1.AddRow(New String() {"VISA"})
            table1.AddRow(New String() {"MASTERCARD"})
            table1.AddRow(New String() {"AMERICAN EXPRESS"})
#ExternalSource("PagoInscripciones.feature",8)
testRunner.Given("las siguientes marcas de tarjetas aceptadas", CType(Nothing,String), table1, "Dadas ")
#End ExternalSource
            Dim table2 As TechTalk.SpecFlow.Table = New TechTalk.SpecFlow.Table(New String() {"Categoría", "Cupos disponibles", "Precio Inscripcion"})
            table2.AddRow(New String() {"Open Masculino", "15", "13000"})
            table2.AddRow(New String() {"Boys", "13", "10500"})
            table2.AddRow(New String() {"Open Femenino", "16", "13000"})
#ExternalSource("PagoInscripciones.feature",14)
testRunner.And("los siguientes cupos por categoría", CType(Nothing,String), table2, "Y ")
#End ExternalSource
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Solo puede realizarse un pago si para la categoría hay espacio libre."),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Inscripciones")>  _
        Public Overridable Sub SoloPuedeRealizarseUnPagoSiParaLaCategoriaHayEspacioLibre_()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Solo puede realizarse un pago si para la categoría hay espacio libre.", CType(Nothing,String()))
#ExternalSource("PagoInscripciones.feature",20)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",7)
Me.FeatureBackground
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",21)
testRunner.When("Steven que es un usuario registrado solicita la inscripcion a la categoría ""Open "& _ 
                    "Masculino""", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Cuando ")
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",22)
testRunner.Then("el cupo se reduce en 1 y ahora quedan ""14"" espacios disponibles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Entonces ")
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",23)
testRunner.And("se emite un cobro por ""13000"" colones a la cuenta del surfista inscrito.", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Y ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Que se permita el pago en línea con una tarjeta de crédito ó débito VISA, MasterC"& _ 
            "ard ó Amex."),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Inscripciones")>  _
        Public Overridable Sub QueSePermitaElPagoEnLineaConUnaTarjetaDeCreditoODebitoVISAMasterCardOAmex_()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Que se permita el pago en línea con una tarjeta de crédito ó débito VISA, MasterC"& _ 
                    "ard ó Amex.", CType(Nothing,String()))
#ExternalSource("PagoInscripciones.feature",26)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",7)
Me.FeatureBackground
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",27)
testRunner.When("Steven realiza el pago por inscripción a la categoría ""Open Masculino""", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Cuando ")
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",28)
testRunner.And("la marca de su tarjeta es ""VISA""", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Y ")
#End ExternalSource
#ExternalSource("PagoInscripciones.feature",29)
testRunner.Then("se genera un cobro por ""13000"" colones exactos", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Entonces ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
