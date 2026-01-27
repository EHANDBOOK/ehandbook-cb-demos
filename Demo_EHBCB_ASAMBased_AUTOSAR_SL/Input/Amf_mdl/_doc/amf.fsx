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
						<SHORT-NAME>Air Mass Flow</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Air Mass Flow</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Amf Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Amf.Amf_mdl</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="SVG" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Luftmassenstrom</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Luftmassenstrom</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									Im Modul Luftmassenstrom (AirMassFlow) wird aus dem
									Saugrohrdruck Mpc_pManiFilt_Sim
									und der Drehzahl
									Epm_rpmEngSpd_Sim die relative Füllung Amf_facRelAir_Sim und
									die Luftmasse
									pro Absaugung Amf_mAirPerStr_Sim berechnet und als
									Nachricht zur Verfügung gestellt.
									Die relative Füllung ist die
									Frischluftmasse im Zylinder unter den dort vorherrschenden
									Bedingungen relativ zur Frischluftmasse im selben Volumen unter
									Normbedingungen (Druck von 1013hPa,
									Temperatur von 273K). Die relative Füllung ist bei Saugmotoren linear vom
									Saugrohrdruck abhängig, wobei der Restgaspartialdruck
									berücksichtigt werden muss, da sich
									der Zylinder beim Auslassen
									des verbrannten Gemisches aufgrund des Totvolumens nicht
									vollständig entleert. Gleichung 5.3 beschreibt den Zusammenhang
									zwischen Saugrohrdruck
									und relativer Füllung, der in der
									Kennlinie Amf_pManiEngSpd2facRelAirCorr_MAP hinterlegt ist.
									Als
									Grundwert für den Restgaspartialdruck wird 150hPa verwendet.
									Die Steigung errechnet
									sich aus dem zweiten Punkt mit 90% bei
									1013hPa. Beide Werte entspringen Erfahrungen
									aus existierenden
									Motorsteuerungen.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>amf_png_1</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Das es sich bei dem Smartmotor um einen mit einem
									Abgasturbolader aufgeladenen Motor
									handelt muss die Kennlinie
									noch verifiziert und gegebenenfalls angepasst werden. Über die
									Kennlinie Amf_rpmEngSpd2facTempCorr_CUR kann bei Bedarf noch
									eine drehzahlabhängige
									Korrektur durchgeführt werden. Die
									Kennlinie ist als Grundwert durchgehend mit
									Eins gefüllt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Um den Einfluss der Temperatur zu Berücksichtigen
									wird der berechnete Basiswert der
									relativen Füllung mit dem
									Faktor Amf_facRelAirTempCorr beaufschlagt, der das Verhältnis
									von Normtemperatur zur Temperatur am Einlass darstellt. Die
									Temperatur im Zylinder
									bei Frischluftansaugung wird nicht
									gemessen und muss daher berechnet werden. Beim
									Durchströmen des
									Einlassventils und dem Verteilen im Zylinder erwärmt sich die
									Luft am
									Ventil selbst, sowie an den Zylinderwänden, wobei die
									Drehzahl eine entscheidende Rolle
									spielt. Sie bestimmt die Zeit,
									die die Luft hat, um sich zu erwärmen. Zur Abschätzung der
									Temperatur der Frischluft im Zylinder wird die
									Differenztemperatur zwischen Kühlmittel
									Ctc_atCool_Sim (quasi
									Temperatur des Motorblocks) und der Frischluft Mtc_atMani_Sim
									gebildet,
									mit dem drehzahlabhängigen Faktor
									Amf_rpmEngSpd2facTempCorr_CUR multipliziert und
									anschließend die
									Frischlufttemperatur addiert. Gleichung 5.4 beschreibt den
									Zusammenhang
									zur Abschätzung der Frischlufttemperatur
									Amf_atAirIntake bei Einlass.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>amf_png_2</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Um die abgesaugte Luftmasse pro Hub zu Berechnen wird
									die Luftmasse unter Normbedingungen
									berechnet und mit der
									relativen Füllung multipliziert. Gleichung 5.5 beschreibt den
									Zusammenhang zur Berechnung der Luftdichte Amf_rohAirDen und
									daraus der Luftmasse
									für den Smartmotor.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>amf_png_3</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Da es sich um in der Regel Konstante Werte handelt,
									könnte die Normluftmasse auch
									direkt als Parameter eingehen.
									Durch die hier gewählte Implementierung zur Berechnung
									der
									Normluftmasse ist jedoch die Möglichkeit für schnelle
									Änderungen geben.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Durch setzen des Flags Amf_flgRelAirOverride kann die
									relative Füllung für die weiteren
									Berechnungen manuell durch
									Amf_facRelAirMan überschrieben werden und durch das
									Flag
									Amf_flgAirMassPerStrOverride die Luftmasse pro Absaugung eines
									Zylinders mit
									Amf_mAirPerStrMan. Die gesamte Auswertung erfolgt
									durch die Funktion Amf_calc im
									Synchron-Raster.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Idee, die Luftmassenerfassung in dieser Art
									umzusetzen, entstammt dem Skript "Engine Control Systems" von
									Georg Mallebrein.
								</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
