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
						<SHORT-NAME>Starter Calculation</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Starter Calculation</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Stc Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>StarterControl.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Starten des Motors</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Starten des Motors</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									Bei einem Startvorgang eines Verbrennungsmotors wird
									mit Hilfe der Klemme 50
									der Anlasser betätigt. Er schleppt den
									Motor auf eine Drehzahl bei der er
									selbstständig auf die
									Leerlaufdrehzahl beschleunigen kann. Der Startvorgang
									muss von
									der Motorsteuerung erkannt werden, damit diese bestimmte
									Anpassungen vornehmen kann.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Bedingungen für den Motorstart:
								</L-1>
							</P>
							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="DE">
											Drehzahl kleiner
											<TT TYPE="PRM">Stc_rpmEngSpedMax</TT>
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">
											Motor in normalem Betriebszustand (
											<TT TYPE="VARIABLE">Opm_idxMode</TT>
											)
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">Startersignal (Klemme 50)</L-1>
									</P>
								</ITEM>
							</LIST>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>stc_png_1</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Programmausschnitt Startvorgang
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
									Bei Erkennung eines Startvorgangs wird die variable
									<TT TYPE="VARIABLE">Stc_stStarter</TT>
									gesetzt.
									Dadurch wird der Flip Flop Baustein (RSFlipFlop)
									solange gesetzt, bis eine
									bestimmte Drehzahl überschritten wird
									(parametrierbar über
									Stc_EngSpdStartOverdrive). Durch Setzten
									dieser Variable wird erstens die
									Drosselklappenstellung mit dem
									Parameter
									<TT TYPE="PRM">T2t_ThrPosStart</TT>
									auf einen während
									des Startvorgangs festen Wert gestellt. Der
									Saugrohrdruck sollte dabei nahe dem
									Umgebungsdruck liegen, um
									genügend Moment für den Hochlauf des Motors zu
									erzeugen.
									Zweitens ist es notwendig, die Einspritzmenge mittels des
									Parameterkennfeldes
									<TT TYPE="PRM">Stc_facFuelCorr_MAP</TT>
									im Vergleich zum Normalbetrieb zu
									erhöhen, um den Wandfilmeffekt
									auszugleichen. Dieser entsteht dadurch, dass
									der eingespritzte
									Kraftstoff nicht komplett verdampft, sondern an den kalten
									Zylinderwänden kondensiert. Der kondensierte Kraftstoff bleibt
									unverbrannt, da
									kein zündfähiges Gemisch vorhanden ist. Je
									kälter der Motor beim Startvorgang
									ist, desto höher muss die
									Einspritzmenge gewählt werden, um den Motor starten
									zu können.
									Dies kann die bis zu 8-fache Menge an Kraftstoff erfordern, die
									bei
									warmem Motor nötig wäre. Das Kennfeld (
									<TT TYPE="PRM">Stc_facFuelCorr_MAP</TT>
									) ist abhängig von der
									Zeit nach Motorstart und der Kühlwassertemperatur des Motors. Eine
									Simulation des Startvorgangs gegen LABCAR ist in Kapitel 6.1
									beschrieben.
								</L-1>
							</P>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Katalysator heizen nach Motorstart</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Katalysator heizen nach Motorstart</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									Nach Beendigung des Startvorgangs erfolgt die
									Übergabe an den Katalysator
									Heizvorgang. Das ist der Fall,
									sobald der Parameter
									Stc_StarterHold gesetzt und die
									Mindestdrehzahl
									Stc_EngSpdSetCatalyserHeating erreicht ist.
									Damit wird der Flip Flop Baustein
									(RSFF_1) auf 1 gesetzt und
									bleibt bis zum Ende der Katalysatorheizzeit aktiv. Die
									Heizzeit
									wird durch einen Counter berechnet, welcher gesetzt wird,
									sobald die
									Katalysatorheizphase aktiv ist. Im Parameter
									Stc_CatalyserHeatingDelay wird die
									Länge der
									Katalysatorheizphase in Sekunden angegeben.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>stc_png_2</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											Aktivierung und Steuerung Katalysator heizen
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
									Zum Heizen des Katalysators soll die Leerlaufdrehzahl angehoben
									und der
									Zündwinkel nach spät gestellt werden. Der Ablauf des
									Vorgangs wird dabei
									zeitgesteuert. Zur Erhöhung der
									Leerlaufdrehzahl wird mit Hilfe des Kennfelds
									<TT TYPE="PRM">Isc_CatHeatTime2HeatingSpeed</TT>
									Zeitabhängig (Stc_CatalyserHeatingTime) die
									jeweils
									parametrierte Soll-Leerlaufdrehzahl ausgegeben. Mittels des
									Parameters
									Stc_flgCatalyserHeating wird die übliche
									Soll-Leerlaufdrehzahl überschrieben.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Der Zündwinkel wird nicht direkt adaptiert, sondern über die
									Anhebung des
									"langsamen Saugrohrdrucks". Dadurch wird über die
									Drosselklappe ein höherer
									Saugrohrdruck eingeregelt, was zur
									Folge hat, dass der Zündwinkelwirkungsgrad
									niedriger und somit
									der Zündwinkel nach spät gestellt wird. Der Verlauf des
									Saugrohrdruckes über der Zeit (
									<TT TYPE="VARIABLE">Stc_CatalyserHeatingTime</TT>
									) wird über das
									Kennfeld
									<TT TYPE="PRM">T2t_CatHeatTime2pManiRes</TT>
									gesteuert. Eine Simulation der Funktion
									des Katalysatorheizen
									gegen LABCAR ist in Kapitel 6.1 beschrieben.
								</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
