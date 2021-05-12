// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.13.1

using AdaptiveCards;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace AdaptiveCardProj.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            //var replyText = $"Echo: {turnContext.Activity.Text}";
            JToken commandToken = null;
            string text = "";
            string command = "";

            if (turnContext.Activity.Text != null)
            {
                text = turnContext.Activity.Text;
            }
            else
            {
                commandToken = JToken.Parse(turnContext.Activity.Value.ToString());
                command = commandToken["Id"].Value<string>();
            }

            if (text.ToLower() == "hi")
            {
                await turnContext.SendActivityAsync(MessageFactory.Attachment(InfoCard()), cancellationToken);
            }
            else if (text == "Ticket" || command == "Ticket")   //command == "Itenary" || 
            {
                await turnContext.SendActivityAsync(MessageFactory.Attachment(ItenaryCard()), cancellationToken);
            }
            //await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        public static Attachment CallingCard()
        {
            AdaptiveCard card = new AdaptiveCard("1.2")
            {

            };

            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };
            return attachment;

        }

        public static Attachment ItenaryCard()
        {
            RegionInfo objRegInfo = new RegionInfo("en-IN");
            string indianCurrency = objRegInfo.CurrencySymbol;

            AdaptiveCard card = new AdaptiveCard("1.2")
            {

                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveTextBlock
                    {
                        Text = "Passengers",
                        Size = AdaptiveTextSize.Large,
                        Color = AdaptiveTextColor.Accent,
                        Weight = AdaptiveTextWeight.Bolder,
                        IsSubtle = false
                    },
                    new AdaptiveTextBlock
                    {
                        Text = "Tarun Singh Mahar",
                        //Size = AdaptiveTextSize.Large,
                        Separator = true
                    },
                    new AdaptiveTextBlock
                    {
                        Text = "Shubham Singh",
                        //Size = AdaptiveTextSize.Large,
                        Spacing = AdaptiveSpacing.None
                    },
                    new AdaptiveTextBlock
                    {
                        Text = "2 Stops",
                        Weight = AdaptiveTextWeight.Bolder,
                        Spacing = AdaptiveSpacing.Medium
                    },
                    new AdaptiveTextBlock
                    {
                        Text = "Fri, May 14 8:30 PM",
                        Weight = AdaptiveTextWeight.Bolder,
                        Spacing = AdaptiveSpacing.None
                    },
                    new AdaptiveColumnSet
                    {
                        Separator = true,
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn
                            {
                                Width = "1",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        Text = "Delhi",
                                        IsSubtle = true
                                    },
                                    new AdaptiveTextBlock
                                    {
                                        Size = AdaptiveTextSize.ExtraLarge,
                                        Text = "DEL",
                                        Color = AdaptiveTextColor.Accent,
                                        Spacing = AdaptiveSpacing.None
                                    }
                                }
                            },
                            new AdaptiveColumn
                            {
                                Width = "auto",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        Text = " ",
                                        //IsSubtle = true
                                    },
                                    new AdaptiveImage
                                    {
                                        UrlString = "https://adaptivecards.io/content/airplane.png",
                                        Size = AdaptiveImageSize.Small,
                                        Spacing = AdaptiveSpacing.None
                                    },
                                }
                            },
                            new AdaptiveColumn
                            {
                                Width = "1",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right,
                                        Text = "Hyderabad",
                                        IsSubtle = true
                                    },
                                    new AdaptiveTextBlock
                                    {
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right,
                                        Size = AdaptiveTextSize.ExtraLarge,
                                        Text = "HYD",
                                        Color = AdaptiveTextColor.Accent,
                                        Spacing = AdaptiveSpacing.None
                                    }
                                }
                            }
                        }
                    },
                    new AdaptiveTextBlock
                    {
                        Text = "Non-Stops",
                        Weight = AdaptiveTextWeight.Bolder,
                        Spacing = AdaptiveSpacing.Medium
                    },
                    new AdaptiveTextBlock
                    {
                        Text = "Fri, May 14 11:30 PM",
                        Weight = AdaptiveTextWeight.Bolder,
                        Spacing = AdaptiveSpacing.None
                    },
                    new AdaptiveColumnSet
                    {
                        Separator = true,
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn
                            {
                                Width = "1",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        Text = "Hyderabad",
                                        IsSubtle = true
                                    },
                                    new AdaptiveTextBlock
                                    {
                                        Size = AdaptiveTextSize.ExtraLarge,
                                        Text = "HYD",
                                        Color = AdaptiveTextColor.Accent,
                                        Spacing = AdaptiveSpacing.None
                                    }
                                }
                            },
                            new AdaptiveColumn
                            {
                                Width = "auto",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        Text = " ",
                                        //IsSubtle = true
                                    },
                                    new AdaptiveImage
                                    {
                                        UrlString = "https://adaptivecards.io/content/airplane.png",
                                        Size = AdaptiveImageSize.Small,
                                        Spacing = AdaptiveSpacing.None
                                    },
                                }
                            },
                            new AdaptiveColumn
                            {
                                Width = "1",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right,
                                        Text = "Pune",
                                        IsSubtle = true
                                    },
                                    new AdaptiveTextBlock
                                    {
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right,
                                        Size = AdaptiveTextSize.ExtraLarge,
                                        Text = "PNQ",
                                        Color = AdaptiveTextColor.Accent,
                                        Spacing = AdaptiveSpacing.None
                                    }
                                }
                            }
                        }
                    },
                    new AdaptiveColumnSet
                    {
                        Spacing = AdaptiveSpacing.Medium,
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn
                            {
                                Width = "1",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        Text = "Total",
                                        Size = AdaptiveTextSize.Medium,
                                        IsSubtle = true
                                    }
                                }
                            },
                            new AdaptiveColumn
                            {
                                Width = "1",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveTextBlock
                                    {
                                        HorizontalAlignment = AdaptiveHorizontalAlignment.Right,
                                        Text = indianCurrency + " 10000/-",
                                        Size = AdaptiveTextSize.Medium,
                                        Weight = AdaptiveTextWeight.Bolder
                                    }
                                }
                            }
                        }
                    }
                }
            };

            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };
            return attachment;
        }

        public static Attachment InfoCard()
        {
            AdaptiveCard card = new AdaptiveCard("1.2")
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveColumnSet
                    {
                        Columns = new List<AdaptiveColumn>()
                        {
                            new AdaptiveColumn
                            {
                                Width = "auto",
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveImage
                                    {
                                        PixelWidth = 100,
                                        UrlString = "https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg",
                                        AltText = "Profile Image"
                                    }
                                }
                            },
                            new AdaptiveColumn
                            {
                                Items = new List<AdaptiveElement>()
                                {
                                    new AdaptiveContainer
                                    {
                                        Items = new List<AdaptiveElement>()
                                        {
                                            new AdaptiveTextBlock
                                            {
                                                Size = AdaptiveTextSize.Large,
                                                Text = "Tarun Singh Mahar"
                                            },
                                            new AdaptiveTextBlock
                                            {
                                                Spacing = AdaptiveSpacing.None,
                                                Size = AdaptiveTextSize.Normal,
                                                Text = "MWP & ChatBot"
                                            },
                                            new AdaptiveTextBlock
                                            {
                                                Spacing = AdaptiveSpacing.Default,
                                                Color = AdaptiveTextColor.Good,
                                                Size = AdaptiveTextSize.Small,
                                                Text = "tarunsingh.mahar@celebaltech.com"
                                            },
                                        }
                                    },
                                    new AdaptiveActionSet
                                    {
                                        Actions = new List<AdaptiveAction>()
                                        {
                                            new AdaptiveOpenUrlAction
                                            {
                                                Title = "Chat",
                                                UrlString = "https://teams.microsoft.com/_#/conversations/19:3e09bb93-9c1c-4402-b2c4-0b11def50fd7_4e7453c8-40f3-4a07-8eb1-15971d526911@unq.gbl.spaces?ctx=chat"
                                            },
                                            new AdaptiveSubmitAction
                                            {
                                                Title = "Ticket",
                                                Type = AdaptiveSubmitAction.TypeName,
                                                Style = "positive",
                                                Id = "Ticket",
                                                Data = new Dictionary<string, object>(){{"msteams", new Dictionary<string, string>(){{"type", "messageBack"}, {"displayText", "Ticket" }, { "value", "{\"Id\":\"Ticket\"}" } } }},
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };
            return attachment;
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome!";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
