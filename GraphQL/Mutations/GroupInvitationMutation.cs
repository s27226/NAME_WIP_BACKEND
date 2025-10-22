using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class GroupInvitationMutation
{
    
        public GroupInvitation CreateGroupInvitation(AppDbContext context, GroupInvitationInput input)
        {
            var invite = new GroupInvitation
            {
                GroupId = input.GroupId,
                InvitingId = input.InvitingId,
                InvitedId = input.InvitedId,
                Sent = DateTime.UtcNow,
                Expiring = DateTime.Now.AddHours(3)
            };
            context.GroupInvitations.Add(invite);
            context.SaveChanges();
            return invite;
        }

        public GroupInvitation? UpdateGroupInvitation(AppDbContext context, UpdateGroupInvitationInput input)
        {
            var invite = context.GroupInvitations.Find(input.Id);
            if (invite == null) return null;
            if (input.GroupId.HasValue) invite.GroupId = input.GroupId.Value;
            if (input.InvitingId.HasValue) invite.InvitingId = input.InvitingId.Value;
            if (input.InvitedId.HasValue) invite.InvitedId = input.InvitedId.Value;
            context.SaveChanges();
            return invite;
        }

        public bool DeleteGroupInvitation(AppDbContext context, int id)
        {
            var invite = context.GroupInvitations.Find(id);
            if (invite == null) return false;
            context.GroupInvitations.Remove(invite);
            context.SaveChanges();
            return true;
        }
}