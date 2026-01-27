<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "fsx_v1_1_0.ml.dtd">
<!--FS2FSX Converter Version 1.0 -->
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>de</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="DE" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN">EDC/ME(D)17</L-4>
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>Torque to throttle calculation</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Torque to throttle calculation</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>						
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>T2t Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>T2t.T2t_mdl</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="SVG" SCALE="0.41">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Momentenumrechnung</SHORT-NAME>							
							<P>
								<L-1 L="DE">
									Das Modul Momentenumrechnung (Torque2Throttle) berechnet aus
									dem aktuellen Zustand
									des Motors und dem benötigten Moment die
									Drosselklappen- und Wastegateposition. Dazu
									wird aus der
									Drehzahl
									<TT TYPE="VARIABLE">Epm_rpmEngSpd_Sim</TT>
									und gewünschten Moment
									<TT TYPE="VARIABLE">Tqs_tqReq_Sim</TT>
									der Soll-
									Saugrohrdruck
									<TT TYPE="PRM">T2t_pManiReqMin</TT>
									dient über
									<TT TYPE="PRM">T2t_rpmEngSpdtqReq2pManiReqBase_MAP</TT>
									festge-
									legt und mit den Kehrwerten des Zündwinkelwirkungsgrad
									<TT TYPE="VARIABLE">T2t_facSparkEff</TT>
									und des
									Lambdawirkungsgrad T2t_facLambdaEff multipliziert,
									wodurch Verluste ausgeglichen wer-
									den.Die untere Begrenzung des
									Saugrohrdruck-Basiswerts durch
									<TT TYPE="PRM">T2t_pManiReqMin</TT>
									dient
									der Sicherheit. Gründe dafür sind:
								</L-1>
							</P>

							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="DE">Der Saugrohrdruck darf nicht zu tief fallen, damit
											keine Dichtungen eingesaugt werden</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">Der Arbeitsbereich des Sensors hat eine Untergrenze
											von 20hPa</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">Die Regler für Drosselklappen- und
											Wastegateposition dürfen keinen Sollwert vorge-
											gebenbekommen, der nicht erreichbar ist.
										</L-1>
									</P>
								</ITEM>
							</LIST>

							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>T2t.T2t_mdl.ThrottleValveControl</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											ThrottleValveControl
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.41">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>


							<P>
								<L-1 L="DE">
									Die Regelungen der Drosselklappe und des Wastegates
									erfolgen jeweils mit PI-Reglern.
									Zwischen beiden besteht eine
									große Abhängigkeit. Je weiter dasWastegate geöffnet ist, desto
									höher ist der Ladedruck und damit die Druckdifferenz vor und
									nach Drosselklappe, was zu
									einem anderen Luftmassenstrom führt.
									Umgekehrt kann bei niedrigen Saugrohrdrücken,
									also wenig Last,
									kein Ladedruck aufgebaut werden.
								</L-1>
							</P>

							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>T2t.T2t_mdl.WastegateControl</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											WastegateControl
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.41">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>

							<P>
								<L-1 L="DE">
									Da am Motor kein Ladedrucksensor verbaut ist, kann dieser nicht
									gemessen werden.
									Um die Steuerung einfach zu halten wird daher
									der Ladedruck unabhängig von der
									Drosselklappe geregelt. Bei
									einem Saugrohrdruck unter Umgebungsdruck wird eine reine
									Saugmotorsteuerung angenommen, d. h., ein Ladedruck von 0bar
									und bei Drücken über
									Umgebungsdruck eine reine Ladedruckregelung
									durchgeführt. Es wird angenommen, dass
									bei weit geöffneter
									Drosselklappe, was bei hohen Saugrohrdruckanforderungen der
									Fall
									ist, der Ladedruck gleich dem Saugrohrdruck ist. Erreicht
									wird das durch entsprechendes
									Parametrieren der Vorsteuerungen
									der Drosselklappen- und Wastegatepositionsvorgabe
									(
									<TT TYPE="VARIABLE">T2t_facThrValveReq_Sim</TT>
									und
									<TT TYPE="VARIABLE">T2t_facWasteGateRate_Sim</TT>
									).
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Grundparametrierung der Kennlinien
									<TT TYPE="VARIABLE">T2t_facSparkEff</TT>
									und des Lambdawirkungsgrad
									<TT TYPE="VARIABLE">T2t_facLambdaEff</TT>
									und des Kennfelds
									<TT TYPE="PRM">T2t_rpmEngSpdtqReq2pManiReqBase_MAP</TT>
									sind eins
									zu eins aus einem vorhandenen BMW-8-Zylinder-Modell
									übernommen und müssen gegebenenfalls
									noch an den Smart-Motor
									angepasst werden.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Reglerauslegung für den Drosselklappensollwert
									erfolgt nach dem Verfahren der experimentellen
									Reglereinstellung nach Ziegler-Nichols. Der I-Anteil des
									Reglers kann durch
									setzen der Nachstellzeit auf einen großen
									Wert (z. B. T2t_tiTnThrValveReqCorr = 106)
									quasi ausgeschaltet
									werden.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Zur Vereinfachung wird hierbei keine
									drehzahlabhängige Verstärkung verwendet, sondern der
									schlechteste Fall, der sich bei hohen Drehzahlen befindet. Die
									kritische Verstärkung liegt bei
									rund KPkrit = 3,5×10-5, woraus
									sich eine Reglerverstärkung Tqs_facKThrValveReqCorr =
									0,4 ×
									KPkrit = 1,4 × 10-5 ergibt. Die kritische Frequenz bzw.
									Periodendauer ergibt sich
									nach Abbildung 5.8 aus dem Mittelwert
									von 10 Schwingungen zu TKrit = 1,61&#x2044;10 sek &#x2248;
									0,16sek. Damit ist Tn = 0,8 × TKrit &#x2248; 0,13sek. Abbildung
									5.11 zeigt die Sprungant-
									wort des geregelten Systems. In Anhang
									F wird die Grundparametrierung des Kennfelds
									T2t_rpmEngSpdpManiReq2facThrValveReqBase_MAP beschrieben. 180
									&#923; [16]
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>t2t_png_1</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Kritische Frequenz der Saugrohrdruckreglerauslegung
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Durch das Flag T2t_pManiReqOverride kann die
									Saugrohrdruckanforderung manuell mit
									T2t_pManiReqMan
									überschrieben werden, bevor sie als Nachricht weitergereicht
									wird. Die
									Auswertung der Funktion T2t_calc erfolgt im
									Synchron-Raster. Die Berechnung der
									Abtastzeit der Regler
									erfolgt, wie in Gleichung 5.10 beschrieben.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>t2t_png_2</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Sprungantwort des Saugrohrdruckreglers
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<NOTE NOTE-TYPE="HINT">
								<P>
									<L-1 L="DE">
										Die Auslegung erfolgt in der Simulation gegen
										LABCAR. Eventuell muss eine
										Anpassung am Motor durchgeführt
										werden.
										Bei der Auslegung des Saugrohrdruckreglers muss
										berücksichtigt werden, dass
										im Modul Drosselklappe (s. auch
										Abschnitt 5.5.1) eine Positionsregelung der
										Drosselklappe
										erfolgt. Es handelt sich um eine Regler-Kaskade, d. h.,
										Änderungen
										am Regler für die Drosselklappenposition können
										Auswirkungen auf die
										Saugrohrdruckregelung haben.
										Zunächst wird
										der Motor nur als Saugmotor betrieben, d. h., das Wastegate
										ist
										immer voll geöffnet. Weiterhin findet nie ein
										Vollastbetrieb statt. Es stellt sich
										kein oder nur ein geringer
										Ladedruck ein, wodurch der Wastegateregler nie in
										Betrieb war
										und die Reglerparameter nicht eingestellt sind.
									</L-1>
								</P>
							</NOTE>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
