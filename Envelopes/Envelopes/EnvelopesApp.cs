using Envelopes.TextMessages;
using Envelopes.Validator;
using Serilog;
using System;

namespace Envelopes
{
    public class EnvelopesApp
    {
        private readonly EnvelopesUI _envelopesUserInterface;

        private const int ENVELOPE_PARAMETRS = 2;
        public EnvelopesApp()
        {
            _envelopesUserInterface = new EnvelopesUI();
        }

        public void Start(string[] args)
        {
            Log.Logger.Information($"Starting app");

            double[] firstEnvelopeSizing,
                secondEnvelopeSizing;

            while (_envelopesUserInterface.IsRun())
            {

                try
                {
                    Log.Logger.Information($"User is inputting parametrs");

                    if(args.Length != 0 && args.Length == ENVELOPE_PARAMETRS)
                    {
                        if(args.Length > ENVELOPE_PARAMETRS)
                        {
                            throw new ArgumentException();
                        }

                        firstEnvelopeSizing = ConvertUsersInput(args[0].Split(' '));
                        secondEnvelopeSizing = ConvertUsersInput(args[1].Split(' '));

                        Array.Clear(args, 0, args.Length);
                    }
                    else
                    {   
                        firstEnvelopeSizing =
                        ConvertUsersInput(_envelopesUserInterface.GetEnvelopeFromUser(UIMessages.INPUT_FIRST_ENVELOPE));

                        secondEnvelopeSizing =
                        ConvertUsersInput(_envelopesUserInterface.GetEnvelopeFromUser(UIMessages.INPUT_SECOND_ENVELOPE));
                    }
                    
                    IEnvelope firstEnvelope = SetEnvelope(firstEnvelopeSizing);

                    IEnvelope secondEnvelope = SetEnvelope(secondEnvelopeSizing);

                    ContainStates state = IsContains(firstEnvelope, secondEnvelope);

                    _envelopesUserInterface.Display(state);
                }
                catch (FormatException ex)
                {
                    _envelopesUserInterface.DisplayExeption(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    _envelopesUserInterface.DisplayExeption(ex.Message);
                }
            }

        }

        private ContainStates IsContains(IEnvelope firstEnvelope, IEnvelope secondEnvelope)
        {
            Log.Logger.Information($"Checking is envelope fits to another one");

            ContainStates state = ContainStates.DoesntContainsAny;

            if (firstEnvelope.IsFits(secondEnvelope))
            {
                state = ContainStates.FirstContainsSecond;
            }
            if (secondEnvelope.IsFits(firstEnvelope))
            {
                state = ContainStates.SecondContainsFirst;
            }

            Log.Logger.Information($"Successfully checked, {state}");

            return state;
        }

        private Envelope SetEnvelope(double[] envelopeSizing)
        {
            EnvelopesValidator validator = new EnvelopesValidator();

            Envelope envelope = new Envelope(envelopeSizing);

            Log.Logger.Information($"Trying to create envelope with width:{envelope.Width} height:{envelope.Height}");

            if (validator.Validate(envelope).IsValid)
            {
                Log.Logger.Information($"Envelope width:{envelope.Width} height:{envelope.Height} is succesfully created");
                return envelope;
            }

            Log.Logger.Warning($"Not valid envelope's width:{envelope.Width} height:{envelope.Height} parametrs input");

            throw new ArgumentException(UIMessages.INVALID_PARAMETRS);
        }

        private double[] ConvertUsersInput(string[] envelopeSizing)
        {
            Log.Logger.Information($"Trying to convert parametrs from string to number");

            double[] parametrs = new double[ENVELOPE_PARAMETRS];

            for (int i = 0; i < ENVELOPE_PARAMETRS; i++)
            {
                try
                {
                    parametrs[i] = Convert.ToDouble(envelopeSizing[i]);
                }
                catch
                {
                    Log.Logger.Warning($"Can not convert inputed envelope's width and height");

                    throw new FormatException(UIMessages.FORMAT_EXEPTION);
                }
            }

            Log.Logger.Information($"Parametrs succesfully parsed");
            return parametrs;
        }
    }
}
